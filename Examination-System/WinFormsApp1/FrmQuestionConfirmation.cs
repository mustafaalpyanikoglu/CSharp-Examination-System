using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class FrmQuestionConfirmation : Form
    {
        private IQuestionService _questionManager = new QuestionManager();
        private SqlManager _sqlManager = new SqlManager();
        private int _selectedQuestionID = 0;
        private List<RadioButton> _optionList = new List<RadioButton>();

        public FrmQuestionConfirmation()
        {
            InitializeComponent();
        }
        //Datagridview'a tasarım ekliyoruz.
        public void DesignDataGridView()
        {
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(32, 36, 48);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(78, 184, 206);
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;


            for (int columnIndex = 0; columnIndex < dataGridView1.Columns.Count; columnIndex++)
            {
                for (int rowIndex = 0; rowIndex < dataGridView1.Rows.Count; rowIndex++)
                {
                    dataGridView1.Rows[rowIndex].Cells[columnIndex].Style.BackColor = Color.FromArgb(32, 36, 48);
                    dataGridView1.Rows[rowIndex].Cells[columnIndex].Style.ForeColor = Color.FromArgb(78, 184, 206);
                }
            }
        }

        //veritabanındaki onaylanmamış soru ID'lerini datagridview'a yüklüyoruz
        public void FillDatagridview()
        {
            SqlConnection sqlConnection = _sqlManager.sqlConnection();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select QuestionID from Questions Where QuestionStatus=0 ", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            DesignDataGridView();
        }

        //datagridview'dan seçilen sorunun verilerini çekiyoruz.
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult result = MessageBox.Show("Doğru soruyu seçtiğinizden emin misiniz?", "Seçim onayı", MessageBoxButtons.YesNo);
            DataGridViewCell clickedCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (result == DialogResult.Yes)
            {
                if (clickedCell.Value != null)// datagridview'a tıklama kontrolü
                {
                    int questionID = Convert.ToInt32(clickedCell.FormattedValue.ToString());
                    BaseResult<Question> dataResult = _questionManager.GetQuestionById(questionID); //<veri tipi>
                    //datagridview'da seçilen soruyu geri dönderiyor
                    if (dataResult is ErrorResult<Question>)
                    {
                        MessageBox.Show((dataResult as ErrorResult<Question>).error);
                    }
                    else
                    {
                        SetLoadedQuestion(dataResult.data);
                        _selectedQuestionID = (int)clickedCell.Value;
                    }
                }
            }
        }

        //Buton listesinde doğru seçeneği bulup işaretliyor.
        public void TickCorrectOption(int rightOption)
        {
            int i = 0;
            _optionList.ForEach(o => {
                o.Checked = rightOption == i + 1 ? true : false;
                if (o.Checked)
                {
                    o.BackColor = Color.Green;
                }
                o.BackColor = o.Checked ? Color.Green : Color.Red;
                i++;
            });
        }


        //Veritabanından gelen soru bilgilerini form sayfasına yüklüyor
        private void SetLoadedQuestion(Question question)
        {
            SubjectNoTxt.Text = question.SubjectNo.ToString();
            UnitNoTxt.Text = question.UnitNo.ToString();
            UnitNameTxt.Text = question.UnitName;
            SubjectNameTxt.Text = question.SubjectName;
            OptionATxt.Text = question.OptionA;
            OptionBTxt.Text = question.OptionB;
            OptionCTxt.Text = question.OptionC;
            OptionDTxt.Text = question.OptionD;
            QuestionRichTxt.Text = question.QuestionTxt;
            MemoryStream ms = new MemoryStream(question.QuestionImage);
            Image returnImage = Image.FromStream(ms);
            pictureBox.Image = returnImage;
            TickCorrectOption(question.RightOption);
        }

        //Form sayfasında yazılan bilgileri temizliyoruz.
        public void ClearLoaded()
        {
            SubjectNoTxt.Text = "";
            UnitNoTxt.Text = "";
            UnitNameTxt.Text = "";
            SubjectNameTxt.Text = "";
            OptionATxt.Text = "";
            OptionBTxt.Text = "";
            OptionCTxt.Text = "";
            OptionDTxt.Text = "";
            QuestionRichTxt.Text = "";
            pictureBox.Image = null;
            radioButtonA.Checked = false;
            radioButtonB.Checked = false;
            radioButtonC.Checked = false;
            radioButtonD.Checked = false;
        }

        

        private void FrmQuestionConfirmation_Load(object sender, EventArgs e)
        {
            FillDatagridview();
            //Form sayfasındaki butonları listeye ekliyoruz.
            _optionList.Add(radioButtonA);
            _optionList.Add(radioButtonB);
            _optionList.Add(radioButtonC);
            _optionList.Add(radioButtonD);
        }


        private void closePictureBox_Click(object sender, EventArgs e)
        {
            FrmAdminMenu frmAdminMenu = new FrmAdminMenu();
            frmAdminMenu.Show();
            this.Hide();
        }

        //Seçieln soruyu onaylıyor ve soru statüsünü 1 yapıyoruz. Böylece soruyu onaylı sorular havuzuna atıyoruz.
        private void onaylaBTN_Click(object sender, EventArgs e)
        {
            if (_selectedQuestionID!=0)
            {
                BaseResult<Question> result2 = _questionManager.UpdateQuestion(_selectedQuestionID);
                if (result2 is SuccessResult<Question>)
                {
                    MessageBox.Show((result2 as SuccessResult<Question>).success);
                    FillDatagridview();
                    _selectedQuestionID = 0;
                    ClearLoaded();
                }
                else
                {
                    MessageBox.Show((result2 as ErrorResult<Question>).error);

                }
            }
            else
            {
                MessageBox.Show("Lütfen bir soru seçiniz.");
            }
        }
    }
}
