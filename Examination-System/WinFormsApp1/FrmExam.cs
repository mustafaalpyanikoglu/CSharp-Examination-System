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
    public partial class FrmExam : Form
    {
        private int _questionCount=0;
        private int _minutes = 9, _second = 60;

        private List<Question> _question;
        private List<Question> _trueAnswerQuestionList = new List<Question>();
        private List<Question> _falseAnswerQuestionsList = new List<Question>();
        private List<RadioButton> _optionList = new List<RadioButton>();

        public FrmExam(List<Question> result)
        {
            InitializeComponent();
            this._question = result;
            _optionList.Add(radioButtonA);
            _optionList.Add(radioButtonB);
            _optionList.Add(radioButtonC);
            _optionList.Add(radioButtonD);
        }


        private void SoruDegisBTN_Click(object sender, EventArgs e)
        {
            _questionCount++;
            QuestionAnswerControl();
        }

        private void Exam_Load(object sender, EventArgs e)
        {
            Saniye.Interval = 1000;
            Saniye.Start();
            QuestionAnswerControl();
        }

        private void SetLoadedQuestion(Question question)
        {
            OptionARichTxt.Text = question.OptionA;
            OptionBRichTxt.Text = question.OptionB;
            OptionCRichTxt.Text = question.OptionC;
            OptionDRichTxt.Text = question.OptionD;
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
            if (_second == 0)
            {
                _minutes--;
                _second = 60;
            }
            saniyeLbl.Text = _second.ToString();
            dakikaLbl.Text = _minutes.ToString();
            _second--;
            if (_minutes < 0)
            {
                Saniye.Stop();
                saniyeLbl.Text = "0";
                dakikaLbl.Text = "0";
            }
        }

        public void RightOptionControl(int rightOption)
        {
            int selectedOption = _optionList.FindIndex(option => option.Checked);
            MessageBox.Show($"{rightOption} - {selectedOption + 1}");
            if (rightOption == selectedOption + 1)
            {
                //sorunun cevabı doğru şık.
                _trueAnswerQuestionList.Add(_question[_questionCount]);

            }
            else
            {
                //sorunun cevabı doğru şık değil.
                _falseAnswerQuestionsList.Add(_question[_questionCount]);
            }
        }

        public void QuestionAnswerControl()
        {
            if (_question.Count() > _questionCount && _minutes > 0)
            {
                SetLoadedQuestion(_question[_questionCount]);
                int rightOption = _question[_questionCount].RightOption;
                
                if(radioButtonA.Checked || radioButtonB.Checked || radioButtonC.Checked || radioButtonD.Checked)
                {
                    RightOptionControl(rightOption);
                }
                else
                {
                    //Soruyu boş geçmiştir.
                    _falseAnswerQuestionsList.Add(_question[_questionCount]);
                }
                foreach (RadioButton radioButton in _optionList)
                {
                    radioButton.Checked = false;
                }
            }
            else
            {
                FrmExamResult frmExamResult = new FrmExamResult(_trueAnswerQuestionList, _falseAnswerQuestionsList,_question);
                frmExamResult.Show();
                this.Hide();
            }
        }
    }
}
