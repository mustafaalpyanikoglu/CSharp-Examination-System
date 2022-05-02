using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    class AuthManager : IAuthService
    {
        public BaseResult<User> Login(User kisi, UserType userType)
        {
            SqlManager sqlManager = new SqlManager();
            SqlCommand command;
            SqlConnection connection = sqlManager.sqlConnection();
            User user;
            bool result = false;
            if (userType == UserType.ADMIN) //Admin musteri girisine göre değerlendirme yapılacak
            {
                user = new AdminAccount();
                command = new SqlCommand("Select * From adminHesaplari where kullaniciadi='" + kisi.UserName + "' and sifre='" + kisi.Password + "'", connection);
            }
            else if (userType == UserType.EXAMINER) //Admin musteri girisine göre değerlendirme yapılacak
            {
                user = new AdminAccount();
                command = new SqlCommand("Select * From ExaminerAccounts where kullaniciadi='" + kisi.UserName + "' and sifre='" + kisi.Password + "'", connection);
            }
            else
            {
                user = new MusteriAccount();
                command = new SqlCommand("Select * From musteriHesaplari where kullaniciadi='" + kisi.UserName + "' and sifre='" + kisi.Password + "'", connection);
            }

            command.Connection = connection;
                
            SqlDataReader sqlDataReader = command.ExecuteReader();
            
            if(sqlDataReader.HasRows)
            {
                result = true;
                while (sqlDataReader.Read()) //veritabanındaki bilgileri okuyoruz
                {
                    user.NameSurname = sqlDataReader["adsoyad"].ToString();

                }
            }
            else
            {
                result = false;
            }
            sqlManager.sqlConnection().Close();
            command.Dispose();
            if(result)
            {
                return new SuccessResult<User>(data:user ,success:"Kullanıcı bulundu");
            }
            else
            {
                return new ErrorResult<User>(data:user,error:"Kullanıcı bulunamadı");
            }
        }

        public void Register(User kisi, UserType userType)
        {
            kisi.SaveData();
        }
    }
}
