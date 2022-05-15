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
        private IQuestionService _questionManager = new QuestionManager();
        private SuccessConstant _successConstant = new SuccessConstant();
        private ErrorConstant _errorConstant = new ErrorConstant();
        
        public KodNoLbl()
        {
            InitializeComponent();
        }
        
        private void Upload_Click(object sender, EventArgs e)
        {
            //resim seçme işlemi için bilgisayadaki resimlere ulaşıyoruz
            openFileDialog1.Filter = "Select image(*.JpG; *.png; *.Gif)|*.JpG; *.png; *.Gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        public void AddQuestion() //Girilen soru bilgilerini SQL'e ekliyoruz
        {
            Question question = new Question();
            question.UnitNo = Convert.ToInt32(UnitNoTxt.Text);
            question.SubjectNo = Convert.ToInt32(SubjectNoTxt.Text);
            question.UnitName = UnitNameTxt.Text;
            question.SubjectName = SubjectNameTxt.Text;;
            question.OptionA = OptionARichTxt.Text;
            question.OptionB = OptionBRichTxt.Text;
            question.OptionC = OptionCRichTxt.Text;
            question.OptionD = OptionDRichTxt.Text;

            question.QuestionTxt = QuestionRichTxt.Text;

            MemoryStream memoryStream = new MemoryStream(); //image array şeklinde tutuyoruz
            pictureBox.Image.Save(memoryStream, pictureBox.Image.RawFormat);
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
            BaseResult<Question> result = _questionManager.AddQuestionData(question);
            if (result.isSuccess)
            {
                MessageBox.Show(_successConstant.AddQuestion);
                OptionARichTxt.Text = "";
                OptionBRichTxt.Text = "";
                OptionCRichTxt.Text = "";
                OptionDRichTxt.Text = "";
                QuestionRichTxt.Text = "";
                pictureBox.Image = null;
            }
            else
            {
                MessageBox.Show(_errorConstant.Error);
            }
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            AddQuestion();
        }

        private void closePictureBox_Click(object sender, EventArgs e)
        {
            FrmChooseAccount frmIlkSayfa = new FrmChooseAccount();
            frmIlkSayfa.Show();
            this.Hide();
        }
    }
}
