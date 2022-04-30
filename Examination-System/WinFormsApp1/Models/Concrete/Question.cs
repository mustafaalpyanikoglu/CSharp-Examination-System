using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormsApp1
{
    public class Question
    {
        private int unitNo;
        public int UnitNo
        {
            get { return unitNo; }
            set { unitNo = value; }
        }
        
        private int subjectNo;
        public int SubjectNo
        {
            get { return subjectNo; }
            set { subjectNo = value; }
        }
        
        private string unitName;
        public string UnitName
        {
            get { return unitName; }
            set { unitName = value; }
        }
        
        private string subjectName;
        public string SubjectName
        {
            get { return subjectName; }
            set { subjectName = value; }
        }

        private string optionA;
        public string OptionA
        {
            get { return optionA; }
            set { optionA = value; }
        }

        private string optionB;
        public string OptionB
        {
            get { return optionB; }
            set { optionB = value; }
        }

        private string optionC;
        public string OptionC
        {
            get { return optionC; }
            set { optionC = value; }
        }

        private string optionD;
        public string OptionD
        {
            get { return optionD; }
            set { optionD = value; }
        }
        
        private int rightOption;
        public int RightOption
        {
            get { return rightOption; }
            set { rightOption = value; }
        }

        private Byte[] questionImage;
        public Byte[] QuestionImage
        {
            get { return questionImage; }
            set { questionImage = value; }
        }

        private string questionStatus;
        public string QuestionStatus
        {
            get { return questionStatus; }
            set { questionStatus = value; }
        }

        private string questionTxt;
        public string QuestionTxt
        {
            get { return questionTxt; }
            set { questionTxt = value; }
        }


    }
}
