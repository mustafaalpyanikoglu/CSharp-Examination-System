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

namespace WinFormsApp1
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void kayıtOlBTN_Click(object sender, EventArgs e)
        {
            FrmKayit frmKayit = new FrmKayit();
            frmKayit.Show();
            this.Hide();
        }

        private void sifreTxt_MouseClick(object sender, MouseEventArgs e)
        {
            sifreTxt.Clear();
            sifreTxt.PasswordChar = '*';
        }

        private void kullaniciAdiTxt_MouseClick(object sender, MouseEventArgs e)
        {
            kullaniciAdiTxt.Clear();
        }

        private void girisBTN_Click(object sender, EventArgs e)
        {
            girisYap(kullaniciAdiTxt.Text,sifreTxt.Text);
        }

        public void girisYap(string ad, string sifre)
        {
            SqlManager sqlManager = new SqlManager();
            SqlCommand command = new SqlCommand("Select *From adminHesaplari where kullaniciadi='" + ad + "' and sifre='" + sifre + "'", sqlManager.sqlConnection());
            sqlManager.sqlConnection();
            SqlDataReader sqlDataReader = command.ExecuteReader();

            if(sqlDataReader.Read())
            {
                MessageBox.Show("Giriş Başarılı");
                //şimdilik bu sayfa
                FrmIlkSayfa frmIlkSayfa = new FrmIlkSayfa();
                frmIlkSayfa.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
            }
            sqlManager.sqlConnection().Close();
            command.Dispose();
            
        }
    }
}
