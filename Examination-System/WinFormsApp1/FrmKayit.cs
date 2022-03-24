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
    public partial class FrmKayit : Form
    {
        public FrmKayit()
        {
            InitializeComponent();
        }

        private void kayitOlBTN_Click(object sender, EventArgs e)
        {
            FrmIlkSayfa frmIlkSayfa = new FrmIlkSayfa();

            //true false bug var ona bakılacak
            if (Variables.test) //admin kayit islemleri
            {
                AdminHesap adminHesap = new AdminHesap();
                adminHesap.AdSoyad = adSoyadTxt.Text;
                adminHesap.KullaniciAdi = kullaniciAdiTxt.Text;
                adminHesap.Sifre = sifreTxt.Text;
                adminHesap.Mail = eMailTxt.Text;

                adminHesap.verileriKaydet();
                MessageBox.Show("admin kayit yapıldı");
            }
            else //musteri kayit islemleri
            {
                musteriHesap musteriHesap = new musteriHesap();
                musteriHesap.AdSoyad = adSoyadTxt.Text;
                musteriHesap.KullaniciAdi = kullaniciAdiTxt.Text;
                musteriHesap.Sifre = sifreTxt.Text;
                musteriHesap.Mail = eMailTxt.Text;

                musteriHesap.musteriVerileriKaydet();
                MessageBox.Show("Musteri kayit yapıldı");
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
