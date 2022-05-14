using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    interface IAuthService
    {
        BaseResult<User> Login(User kisi,UserType userType);//Giriş için gerekli kontrolleri sağlıyor
        void Register(User kisi, UserType userType); //Kullanıcı bilgilerini veritabanına ekliyor.
        BaseResult<User> ForgotPassword(User kisi, UserType userType); //Şifre unutulması durumunda veritabanından şifreyi çekiyor
    }
}
