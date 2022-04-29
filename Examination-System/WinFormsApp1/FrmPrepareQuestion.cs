using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace WinFormsApp1
{
    public partial class KodNoLbl : Form
    {
        private QuestionManager _questionManager = new QuestionManager();
        private SqlManager _sqlManager = new SqlManager();
        private SqlCommand _sqlCommand;
        
        public KodNoLbl()
        {
            InitializeComponent();
        }
        

        private void DeleteData()
        {
            SqlConnection sqlConnection = _sqlManager.sqlConnection();
            _sqlCommand = new SqlCommand("Delete from Table1 where id=@id", sqlConnection);
            _sqlCommand.Parameters.AddWithValue("@id", SqlDbType.Int).Value = id1.Text;
            _sqlCommand.ExecuteNonQuery();
            _sqlManager.sqlConnection().Close();
            //LoadData();
            pictureBox1.Image = null;
            textBox1.Text = "";
            id1.Text = "";
        }

        private void ShowData()
        {
            id1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            MemoryStream memoryStream = new MemoryStream((Byte[])dataGridView1.CurrentRow.Cells[2].Value);
            pictureBox1.Image = Image.FromStream(memoryStream);
        }

        private void FrmSinavHazirlamaModülü_Load(object sender, EventArgs e)
        {
            datagridviewaSorularıYazdırma();

            BaseResult<List<Question>> result = _questionManager.LoadData();
            if(result.isSuccess)
            {
                //sqlde bulunan verilerin hepsini liste'de geri gönderdik
                MessageBox.Show(result.data[0].QuestionTxt);
            }
            else
            {
                MessageBox.Show((result as ErrorResult<List<Question>>).error); //result'u errorresult olarak kabul ediyoruz
            }
        }

        public void datagridviewaSorularıYazdırma()
        {
            SqlConnection sqlConnection = _sqlManager.sqlConnection();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select QuestionID,UnitNo,SubjectNo,UnitName,SubjectName,QuestionTxt from Questions ", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView2.DataSource = dataTable;  

        }


        private void dataGridView1_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteData();
        }
        
        private void Upload_Click(object sender, EventArgs e)
        {
            //resim seçme işlemi için bilgisayadaki resimlere ulaşıyoruz
            openFileDialog1.Filter = "Select image(*.JpG; *.png; *.Gif)|*.JpG; *.png; *.Gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            //Girilen soru bilgilerini SQL'e ekliyoruz
            Question question = new Question();
            question.UnitNo = Convert.ToInt32(UnitNoTxt.Text);
            question.SubjectNo = Convert.ToInt32(SubjectNoTxt.Text);
            question.UnitName = UnitNameTxt.Text;
            question.SubjectName = SubjectNameTxt.Text;
            question.OptionA = OptionATxt.Text;
            question.OptionB = OptionBTxt.Text;
            question.OptionC = OptionCTxt.Text;
            question.OptionD = OptionDTxt.Text;
            question.QuestionTxt = QuestionRichTxt.Text;
            
            MemoryStream memoryStream = new MemoryStream(); //image array şeklinde tutuyoruz
            pictureBox2.Image.Save(memoryStream, pictureBox2.Image.RawFormat);
            question.QuestionImage = memoryStream.ToArray();
            
            if (radioButtonA.Checked)
            {
                question.RightOption = 1;
            }
            else if (radioButtonB.Checked)
            {
                question.RightOption = 2;
            }
            else if (radioButtonC.Checked)
            {
                question.RightOption = 3;
            }
            else if (radioButtonD.Checked)
            {
                question.RightOption = 4;
            }
            
            _questionManager.AddQuestionData(question);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //datagridview'dan seçilen sorunun verilerini çekme
            DialogResult result = MessageBox.Show("Doğru soruyu seçtiğinizden emin misiniz?", "Seçim kontrolü", MessageBoxButtons.YesNo);
            DataGridViewCell clickedCell = dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (result==DialogResult.Yes)
            {
                if (clickedCell.Value != null)// datagridview'a tıklama kontrolü
                {
                    int questionID=Convert.ToInt32(clickedCell.FormattedValue.ToString());
                    BaseResult<Question> dataResult = _questionManager.UploadQuestion(questionID); //<veri tipi>
                    //datagridview'da seçilen soruyu geri dönderiyor
                    if (dataResult is ErrorResult<Question>) //2.çözüm->if(!dataResult.isSuccess)
                    {
                        MessageBox.Show((dataResult as ErrorResult<Question>).error);
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream(dataResult.data.QuestionImage);
                        Image returnImage = Image.FromStream(ms);
                        pictureBox1.Image = returnImage;
                        //MessageBox.Show(dataResult.data.QuestionTxt);
                    }
                }
            }
            
        }
    }
}
