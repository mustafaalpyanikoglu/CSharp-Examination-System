using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    class musteriHesap:Kisi
    {
        public void musteriVerileriKaydet()
        {
            SqlManager sqlManager = new SqlManager();
            sqlManager.sqlConnection();
            //values (@p1,@p2,@p3,@p4,@p5)
            SqlCommand komut = new SqlCommand("Insert into musteriHesaplari(adsoyad,kullaniciadi,sifre,email) values (@p1,@p2,@p3,@p4)", sqlManager.sqlConnection());
            komut.Parameters.AddWithValue("@p1", base.AdSoyad);
            komut.Parameters.AddWithValue("@p2", base.KullaniciAdi);
            komut.Parameters.AddWithValue("@p3", base.Sifre);
            komut.Parameters.AddWithValue("@p4", base.Mail);
            komut.ExecuteNonQuery();
            sqlManager.sqlConnection().Close();
        }
    }
}
