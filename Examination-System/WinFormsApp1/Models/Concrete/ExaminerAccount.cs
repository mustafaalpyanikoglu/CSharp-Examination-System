using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    class ExaminerAccount:User
    {
        public override void SaveData() //admin bilgilerini kaydediyoruz
        {
            SqlManager sqlManager = new SqlManager();
            sqlManager.sqlConnection();
            SqlCommand komut = new SqlCommand("Insert into ExaminerAccounts(adsoyad,kullaniciadi,sifre,email) values (@p1,@p2,@p3,@p4)", sqlManager.sqlConnection());
            komut.Parameters.AddWithValue("@p1", base.NameSurname);
            komut.Parameters.AddWithValue("@p2", base.UserName);
            komut.Parameters.AddWithValue("@p3", base.Password);
            komut.Parameters.AddWithValue("@p4", base.Mail);
            komut.ExecuteNonQuery();
            sqlManager.sqlConnection().Close();
        }
    }
}
