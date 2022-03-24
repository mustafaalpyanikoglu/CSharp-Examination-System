using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    class AdminHesap
    {
        private string adSoyad;
        public string AdSoyad 
        {
            get { return adSoyad; }
            set { adSoyad = value; }
        }

        private string kullaniciAdi;
        public string KullaniciAdi
        {
            get { return kullaniciAdi; }
            set { kullaniciAdi = value; }
        }

        private string sifre;
        public string Sifre
        {
            get { return sifre; }
            set { sifre = value; }
        }

        private string mail;
        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }

        public void verileriKaydet()
        {

            SqlManager sqlManager = new SqlManager();
            sqlManager.sqlConnection();
            //values (@p1,@p2,@p3,@p4,@p5)
            SqlCommand komut = new SqlCommand("Insert into adminHesaplari(adsoyad,kullaniciadi,sifre,email) values (@p1,@p2,@p3,@p4)", sqlManager.sqlConnection());
            komut.Parameters.AddWithValue("@p1", AdSoyad);
            komut.Parameters.AddWithValue("@p2", kullaniciAdi);
            komut.Parameters.AddWithValue("@p3", sifre);
            komut.Parameters.AddWithValue("@p4", mail);
            komut.ExecuteNonQuery();
            sqlManager.sqlConnection().Close();
        }

    }
}
