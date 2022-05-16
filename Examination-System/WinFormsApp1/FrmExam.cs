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
        private List<Question> _trueAnswerQuestionList = new List<Question>(); //Doğru cevaplanan soruları tutuyor
        private List<Question> _falseAnswerQuestionsList = new List<Question>(); //Yanlış işaretlenen soruları tutuyor
        private List<RadioButton> _optionList = new List<RadioButton>(); //A-B-C-D şıklarını bir listeye ekliyoruz.

        public FrmExam(List<Question> result)
        {
            InitializeComponent();
            //Hazırlanan 10 soruluk soru listesi form sayfasına yükleniyor
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

        //Çekilen soru bilgilerini forma yüklüyor
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

        //Saniye 60'dan geri sayılıyor 0'a ulaştığında dakika da bir düşüyor
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
                FrmExamResult frmExamResult = new FrmExamResult(_trueAnswerQuestionList, _falseAnswerQuestionsList, _question);
                frmExamResult.Show();
                this.Hide();
            }
        }

        //Sorunun cevabına göre doğru soru havuzuna veya yanlış soru havuzuna atılır
        public void RightOptionControl(int rightOption)
        {
            int selectedOption = _optionList.FindIndex(option => option.Checked);
            //MessageBox.Show($"{rightOption} - {selectedOption + 1}"); İşarlenen cevabı ve sorunun cevabını gösteriyor
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

        //Soruyu cevaplandı mı cevaplandıysa doğru şıkmı olduğu kontrol edilir
        public void QuestionAnswerControl()
        {
            if (_question.Count() > _questionCount) //Her yeni soruya geçildiğinde listedeki soruların da tamamlanması koşulu var && dakika 0 a ulaşırsa sınav biter
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
