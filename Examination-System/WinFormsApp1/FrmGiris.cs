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
        FrmIlkSayfa frmIlkSayfa = new FrmIlkSayfa();
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
            sifreTxt.Clear(); //tıkladığında textbox temizlenecek
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
        SqlCommand command;

        public void girisYap(string ad, string sifre)
        {
            SqlManager sqlManager = new SqlManager();
            if(Variables.test) //Admin musteri girisine göre değerlendirme yapılacak
            {
                command = new SqlCommand("Select *From adminHesaplari where kullaniciadi='" + ad + "' and sifre='" + sifre + "'", sqlManager.sqlConnection());
            }
            else
            {
                command = new SqlCommand("Select *From musteriHesaplari where kullaniciadi='" + ad + "' and sifre='" + sifre + "'", sqlManager.sqlConnection());
            }
            sqlManager.sqlConnection(); //veritabanına bağlanıyoruz
            SqlDataReader sqlDataReader = command.ExecuteReader();

            if(sqlDataReader.Read()) //veritabanındaki bilgileri okuyoruz
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
