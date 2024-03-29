﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FrmStudentMenu : Form
    {
        private SuccessConstant _successConstant = new SuccessConstant();
        private ErrorConstant _errorConstan = new ErrorConstant();
        public FrmStudentMenu()
        {
            InitializeComponent();
        }

        //Veritabanından random 10 adet soru çekeriz.Ve öğrenci için sınav başlar.
        private void SinavaGirBoxBTN_Click(object sender, EventArgs e)
        {
            IQuestionService questionManager = new QuestionManager();
            BaseResult<List<Question>> result = questionManager.RandomQuestion(); //Veri tabanından random 10 adet soru çekiyoruz
            if (result.data.Count == 0) //Soru çekilemediyse hata verir
            {
                MessageBox.Show(_errorConstan.QuestionNotFound);
            }
            else
            {
                MessageBox.Show(_successConstant.ExamStart);
                FrmExam exam = new FrmExam(result.data);
                exam.Show();
                this.Hide();
            }
        }

        private void closePictureBox_Click(object sender, EventArgs e)
        {
            FrmChooseAccount frmChooseAccount = new FrmChooseAccount();
            frmChooseAccount.Show();
            this.Hide();
        }
    }
}
