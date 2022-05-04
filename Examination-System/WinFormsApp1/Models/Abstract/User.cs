using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public abstract class User
    {
        //Kullanıcı'da hangi bilgiler bulunacağını içeriyor.
        private string nameSurname;
        public string NameSurname
        {
            get { return nameSurname; }
            set { nameSurname = value; }
        }

        private string userName;
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private string mail;
        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }

        public abstract void SaveData();
        //public abstract void DataControl(string kullaniciAd, string mail);

    }
}
