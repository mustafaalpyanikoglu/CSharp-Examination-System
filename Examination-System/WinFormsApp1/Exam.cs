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


namespace WinFormsApp1
{
    public partial class Exam : Form
    {
        private int _questionCount=0;
        IQuestionService questionManager = new QuestionManager();
        private List<Question> _question;
        public Exam(List<Question> result)
        {
            InitializeComponent();
            this._question = result;
        }

        private void SoruDegisBTN_Click(object sender, EventArgs e)
        {
            _questionCount++;
            if(_question.Count() > _questionCount)
            {
                SetLoadedQuestion(_question[_questionCount]);
            }

        }
        private int dk = 10, sn = 60;
        private void Exam_Load(object sender, EventArgs e)
        {
            Saniye.Interval = 100;
            Saniye.Start();
            
            SetLoadedQuestion(_question[0]);
        }

        private void SetLoadedQuestion(Question question)
        {
            OptionATxt.Text = question.OptionA;
            OptionBTxt.Text = question.OptionB;
            OptionCTxt.Text = question.OptionC;
            OptionDTxt.Text = question.OptionD;
            QuestionRichTxt.Text = question.QuestionTxt;
            MemoryStream ms = new MemoryStream(question.QuestionImage);
            Image returnImage = Image.FromStream(ms);
            pictureBox.Image = returnImage;
        }

        private void Saniye_Tick(object sender, EventArgs e)
        {
            Timer();
        }

        public void Timer()
        {
           
            if (sn == 0)
            {
                dk--;
                sn = 60;
            }
            saniyeLbl.Text = sn.ToString();
            dakikaLbl.Text = dk.ToString();
            sn--;
            if (dk < 0)
            {
                Saniye.Stop();
                saniyeLbl.Text = "0";
                dakikaLbl.Text = "0";
            }
            
        }


    }
}
