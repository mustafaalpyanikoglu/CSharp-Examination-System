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
    public partial class FrmChooseAccount : Form
    {
        public bool isAdminMusteri;
        public FrmChooseAccount()
        {
            InitializeComponent();
        }

        private void ogrenciBTN_Click(object sender, EventArgs e)
        {
            //Variables.test = false;
            
            FrmLogin frmGiris = new FrmLogin(UserType.CUSTOMER);
            frmGiris.Show();
            this.Hide();
        }

        private void AdminBTN_Click(object sender, EventArgs e)
        {
            //Variables.test = true;
            
            FrmLogin frmGiris = new FrmLogin(UserType.ADMIN);
            frmGiris.Show();
            this.Hide();
        }

        private void ExaminerBoxBTN_Click(object sender, EventArgs e)
        {
            FrmLogin frmGiris = new FrmLogin(UserType.EXAMINER);
            frmGiris.Show();
            this.Hide();
        }
    }
}
