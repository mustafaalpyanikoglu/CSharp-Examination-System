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
    public partial class FrmExamResult : Form
    {
        private List<Question> _rightQuestion, _wrongQuestion, _questions;
        private int _selectedQuestion;
        private List<RadioButton> _optionList = new List<RadioButton>();


        public FrmExamResult(List<Question> rightQuestion , List<Question> wrongQuestion,List<Question> question)
        {
            InitializeComponent();
            _rightQuestion = rightQuestion;
            _wrongQuestion = wrongQuestion;
            this._questions = question;
        }

        private void closePictureBox_Click(object sender, EventArgs e)
        {
            FrmStudentMenu frmMusteriMenu = new FrmStudentMenu();
            frmMusteriMenu.Show();
            this.Hide();
        }

        public void PrintAnswer() //Hangi soruları doğru/yanlış yaptığını listview'a yazdırıyor.
        {
            for(int i=0; i<_questions.Count;i++)
            {
                bool isRight = _rightQuestion.Contains(_questions[i]);
                
                string[] row = { (i + 1).ToString(), isRight ? "Doğru" : "Yanlış" };
                ListViewItem listViewItem = new ListViewItem(row);
                listViewItem.ForeColor = isRight ? Color.Green : Color.Red;
                listView1.Items.Add(listViewItem);
            }
        }

        private void SetLoadedQuestion(Question question) //Soru verilerini yüklüyor
        {
            OptionATxt.Text = question.OptionA;
            OptionBTxt.Text = question.OptionB;
            OptionCTxt.Text = question.OptionC;
            OptionDTxt.Text = question.OptionD;
            QuestionRichTxt.Text = question.QuestionTxt;
            TickCorrectOption(question.RightOption);
            MemoryStream ms = new MemoryStream(question.QuestionImage);
            Image returnImage = Image.FromStream(ms);
            pictureBox.Image = returnImage;
        }

        public void TickCorrectOption(int rightOption) //Doğru seçeneği bulup işaretliyor.
        {
            int i = 0;
            _optionList.ForEach(o => {
                o.Checked = rightOption == i + 1 ? true : false;
                if(o.Checked)
                {
                    o.BackColor = Color.Green;
                }
                o.BackColor = o.Checked ? Color.Green : Color.Red;
                i++;
            });
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            //Listview'dan istediğimiz soruyu seçiyoruz ve verilerini yüklüyoruz
            _selectedQuestion = listView1.SelectedIndices[0];
            SetLoadedQuestion(_questions[_selectedQuestion]);
        }

        private void FrmExamResult_Load(object sender, EventArgs e)
        {
            DogruSayisiLbl.Text = "Doğru Sayısı: " + _rightQuestion.Count;
            YanlisSayisiLbl.Text = "Yanlış Sayısı: " + _wrongQuestion.Count;
            PrintAnswer();
            _optionList.Add(radioButtonA);
            _optionList.Add(radioButtonB);
            _optionList.Add(radioButtonC);
            _optionList.Add(radioButtonD);
        }


    }
}
