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
    public partial class FrmForgotPassword : Form
    {
        private UserType _userType;
        private IAuthService _authService = new AuthManager();

        private User _user;
        public FrmForgotPassword(UserType userType)
        {
            InitializeComponent();
            this._userType = userType;
        }

        private void eMailTxt_MouseClick(object sender, MouseEventArgs e)
        {
            eMailTxt.Clear(); //tıkladığında textbox temizlenecek
        }

        private void kullaniciAdiTxt_MouseClick(object sender, MouseEventArgs e)
        {
            kullaniciAdiTxt.Clear();
        }

        //Kişi giriş yaparken seçtiği profil ile bizde bulunan enum yapısına göre hesap bilgilerini çekiyoruz.
        private void sifreHatirlaBTN_Click(object sender, EventArgs e)
        {
            if (this._userType == UserType.ADMIN) 
            {
                _user = new AdminAccount();
                _user.UserName = kullaniciAdiTxt.Text;
                _user.Mail = eMailTxt.Text;
            }
            else if (this._userType == UserType.EXAMINER)
            {
                _user = new ExaminerAccount();
                _user.UserName = kullaniciAdiTxt.Text;
                _user.Mail = eMailTxt.Text;
            }
            else
            {
                _user = new MusteriAccount();
                _user.UserName = kullaniciAdiTxt.Text;
                _user.Mail = eMailTxt.Text;
            }
            BaseResult<User> result = _authService.ForgotPassword(_user, this._userType);
            if (!result.isSuccess)
            {
                MessageBox.Show("Hatalı");
            }
            else
            {
                MessageBox.Show("Şifreniz: "+result.data.Password);
            }
            FrmChooseAccount frmIlkSayfa = new FrmChooseAccount();
            frmIlkSayfa.Show();
            this.Hide();
        }
    }
}
