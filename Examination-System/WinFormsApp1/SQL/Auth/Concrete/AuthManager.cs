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
        private SqlManager _sqlManager = new SqlManager();
        private SqlCommand _command;
        private User _user;
        private bool _result;
        private SuccessConstant _successConstant = new SuccessConstant();
        private ErrorConstant _errorConstants = new ErrorConstant();

        public BaseResult<User> ForgotPassword(User kisi,UserType userType)
        {
            SqlConnection sqlConnection = _sqlManager.sqlConnection();
            if (userType== UserType.ADMIN)
            {
                _user = new AdminAccount();
                _command = new SqlCommand("Select * From Admins where kullaniciadi='" + kisi.UserName + "' and email='" + kisi.Mail + "'", sqlConnection);

            }
            else if(userType==UserType.EXAMINER)
            {
                _user = new ExaminerAccount();
                _command = new SqlCommand("Select * From Examiners where kullaniciadi='" + kisi.UserName + "' and email='" + kisi.Mail + "'", sqlConnection);
            }
            else
            {
                _user = new MusteriAccount();
                _command = new SqlCommand("Select * From Students where kullaniciadi='" + kisi.UserName + "' and email='" + kisi.Mail + "'", sqlConnection);
            }
            _command.Connection = sqlConnection;

            SqlDataReader reader = _command.ExecuteReader();

            if (reader.HasRows)
            {
                _result = true;
                while (reader.Read()) //veritabanındaki bilgileri okuyoruz
                {
                    _user.Password = reader["sifre"].ToString();
                }
            }
            else
            {
                _result = false;
            }
            _sqlManager.sqlConnection().Close();
            _command.Dispose();
            if (_result)
            {
                return new SuccessResult<User>(data: _user, success: _successConstant.UserFound);
            }
            else
            {
                return new ErrorResult<User>(data: _user, error: _errorConstants.UserNotFound);
            }

        }

        public BaseResult<User> Login(User kisi, UserType userType)
        {
            SqlConnection connection = _sqlManager.sqlConnection();
            if (userType == UserType.ADMIN) //Admin musteri girisine göre değerlendirme yapılacak
            {
                _user = new AdminAccount();
                _command = new SqlCommand("Select * From Admins where kullaniciadi='" + kisi.UserName + "' and sifre='" + kisi.Password + "'", connection);
            }
            else if (userType == UserType.EXAMINER) //Admin musteri girisine göre değerlendirme yapılacak
            {
                _user = new AdminAccount();
                _command = new SqlCommand("Select * From Examiners where kullaniciadi='" + kisi.UserName + "' and sifre='" + kisi.Password + "'", connection);
            }
            else
            {
                _user = new MusteriAccount();
                _command = new SqlCommand("Select * From Students where kullaniciadi='" + kisi.UserName + "' and sifre='" + kisi.Password + "'", connection);
            }

            _command.Connection = connection;
                
            SqlDataReader sqlDataReader = _command.ExecuteReader();
            
            if(sqlDataReader.HasRows)
            {
                _result = true;
                while (sqlDataReader.Read()) //veritabanındaki bilgileri okuyoruz
                {
                    _user.NameSurname = sqlDataReader["adsoyad"].ToString();
                }
            }
            else
            {
                _result = false;
            }
            _sqlManager.sqlConnection().Close();
            _command.Dispose();
            if(_result)
            {
                return new SuccessResult<User>(data:_user ,success:_successConstant.UserFound);
            }
            else
            {
                return new ErrorResult<User>(data:_user,error:_errorConstants.UserNotFound);
            }
        }

        public void Register(User kisi, UserType userType)
        {
            kisi.SaveData();
        }
    }
}
