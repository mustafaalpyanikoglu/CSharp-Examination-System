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
using System.Data;

namespace WinFormsApp1
{
    partial class FrmRegister : Form
    {
        private UserType userType;
        public FrmRegister(UserType userType)
        {
            InitializeComponent();
            this.userType = userType;
        }

        private void kayitOlBTN_Click(object sender, EventArgs e)
        {
            FrmIlkSayfa frmIlkSayfa = new FrmIlkSayfa();

            if (this.userType == UserType.ADMIN)
            {
                User _user = new AdminAccount();
                _user.UserName = kullaniciAdiTxt.Text;
                _user.NameSurname = adSoyadTxt.Text;
                _user.Password = sifreTxt.Text;
                _user.Mail = eMailTxt.Text;
                _user.SaveData();
            }
            else if (this.userType == UserType.EXAMINER)
            {
                User _user = new ExaminerAccount();
                _user.UserName = kullaniciAdiTxt.Text;
                _user.NameSurname = adSoyadTxt.Text;
                _user.Password = sifreTxt.Text;
                _user.Mail = eMailTxt.Text;
                _user.SaveData();
            }
            else
            {
                User _user = new MusteriAccount();
                _user.UserName = kullaniciAdiTxt.Text;
                _user.NameSurname = adSoyadTxt.Text;
                _user.Password = sifreTxt.Text;
                _user.Mail = eMailTxt.Text;
                _user.SaveData();
            }
            frmIlkSayfa.Show();
            this.Hide();
        }
        public void verileriGoruntule()  //admin müşterileri görmesi için eklenecek
        {
            SqlManager sqlManager = new SqlManager();
            DataSet daset = new DataSet();
            sqlManager.sqlConnection();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select *From adminHesaplari", sqlManager.sqlConnection());
            sqlDataAdapter.Fill(daset, "adminHesaplari");
            dataGridView1.DataSource = daset.Tables["adminHesaplari"];
            sqlManager.sqlConnection().Close();
        }

        //Textbox'a tıkladığımızda üstündeki yazıyı silmemize yarar
        private void Clear(object sender, MouseEventArgs e)
        {
            adSoyadTxt.Clear();
        }

        private void kullaniciAdiTxt_MouseClick(object sender, MouseEventArgs e)
        {
            kullaniciAdiTxt.Clear();
        }

        private void sifreTxt_MouseClick(object sender, MouseEventArgs e)
        {
            sifreTxt.Clear();
        }

        private void eMailTxt_MouseClick(object sender, MouseEventArgs e)
        {
            eMailTxt.Clear();
        }
    }
}
