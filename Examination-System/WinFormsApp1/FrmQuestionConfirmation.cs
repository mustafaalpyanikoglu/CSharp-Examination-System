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
        private bool _isApproveBtn = false;

        public FrmQuestionConfirmation()
        {
            InitializeComponent();
        }

        public void datagridviewaSorularıYazdırma()
        {
            SqlConnection sqlConnection = _sqlManager.sqlConnection();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from Questions ", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;  

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //datagridview'dan seçilen sorunun verilerini çekme
            DialogResult result = MessageBox.Show("Doğru soruyu seçtiğinizden emin misiniz?", "Seçim onayı", MessageBoxButtons.YesNo);
            DataGridViewCell clickedCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (result == DialogResult.Yes)
            {
                if (clickedCell.Value != null)// datagridview'a tıklama kontrolü
                {
                    int questionID = Convert.ToInt32(clickedCell.FormattedValue.ToString());
                    BaseResult<Question> dataResult = _questionManager.GetQuestionById(questionID); //<veri tipi>
                    //datagridview'da seçilen soruyu geri dönderiyor
                    if (dataResult is ErrorResult<Question>) //2.çözüm->if(!dataResult.isSuccess)
                    {
                        MessageBox.Show((dataResult as ErrorResult<Question>).error);
                    }
                    else
                    {
                        //MemoryStream ms = new MemoryStream(dataResult.data.QuestionImage);
                        //Image returnImage = Image.FromStream(ms);
                        //pictureBox1.Image = returnImage;
                        BaseResult<Question> result2= _questionManager.UpdateQuestion(dataResult.data.QuestionId);
                        if (result2 is ErrorResult<Question>)
                        {
                            MessageBox.Show((result2 as ErrorResult<Question>).error);
                        }
                        else
                        {
                            MessageBox.Show((result2 as SuccessResult<Question>).success);
                            datagridviewaSorularıYazdırma();
                        }
                    }
                }
            }
        }

        private void FrmQuestionConfirmation_Load(object sender, EventArgs e)
        {
            datagridviewaSorularıYazdırma();
        }

        private void onaylaBTN_Click(object sender, EventArgs e)
        {
            _isApproveBtn = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void KapatBTN_Click(object sender, EventArgs e)
        {
            FrmAdminMenu frmAdminMenu = new FrmAdminMenu();
            frmAdminMenu.Show();
            this.Hide();
        }
    }
}
