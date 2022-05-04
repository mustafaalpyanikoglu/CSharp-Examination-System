using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    interface IAuthService
    {
        BaseResult<User> Login(User kisi,UserType userType);
        void Register(User kisi, UserType userType);
        BaseResult<User> ForgotPassword(User kisi, UserType userType);
    }
}
