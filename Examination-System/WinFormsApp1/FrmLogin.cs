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
    partial class FrmLogin : Form
    {
        private UserType _userType;

        public FrmLogin(UserType userType)
        {
            InitializeComponent();
            this._userType = userType;
        }

        private void kayıtOlBTN_Click(object sender, EventArgs e)
        {
            FrmRegister frmKayit = new FrmRegister(this._userType);
            frmKayit.Show();
            this.Hide();
        }

        private void sifreTxt_MouseClick(object sender, MouseEventArgs e)
        {
            sifreTxt.Clear(); //tıkladığında textbox temizlenecek
            sifreTxt.PasswordChar = '*';
        }

        private void kullaniciAdiTxt_MouseClick(object sender, MouseEventArgs e)
        {
            kullaniciAdiTxt.Clear();
        }

        private void girisBTN_Click(object sender, EventArgs e)
        {
            //IAuthService authService = new AuthManager();
            IAuthService authService;
            User _user;
            if(this._userType==UserType.ADMIN)
            {
                _user =new AdminAccount();
                _user.UserName = kullaniciAdiTxt.Text;
                _user.Password = sifreTxt.Text;
            }
            else if(this._userType==UserType.EXAMINER)
            {
                _user = new ExaminerAccount();
                _user.UserName = kullaniciAdiTxt.Text;
                _user.Password = sifreTxt.Text;
            }
            else
            {
                _user = new MusteriAccount();
                _user.UserName = kullaniciAdiTxt.Text;
                _user.Password = sifreTxt.Text;
            }
            AuthManager authManager = new AuthManager();
            BaseResult<User> result= authManager.Login(_user, this._userType);
            if(!result.isSuccess)
            {
                MessageBox.Show("Hatalı");
            }
            else
            {
                NavigateToHomeControl(this._userType);
            }

        }

        public void NavigateToHomeControl(UserType userType)
        {
            //Girilen hesap bilgilerine göre hesabın erişebileceği sayfalar açılıyor.
            if(userType==UserType.ADMIN)
            {
                FrmAdminMenu frmAdminMenu = new FrmAdminMenu();
                frmAdminMenu.Show();
                this.Hide();
            }
            else if(userType==UserType.EXAMINER)
            {
                KodNoLbl frmSinavHazirlamaModülü = new KodNoLbl();
                frmSinavHazirlamaModülü.Show();
                this.Hide();
            }
            else
            {
                FrmStudentMenu frmMusteriMenu = new FrmStudentMenu();
                frmMusteriMenu.Show();
                this.Hide();
            }
        }

        private void SifreUnuttumBTN_Click(object sender, EventArgs e)
        {
            UserType userType = this._userType;
            FrmForgotPassword frmForgotPassword = new FrmForgotPassword(userType);
            frmForgotPassword.Show();
            this.Hide();

        }

        private void closePictureBox_Click(object sender, EventArgs e)
        {
            FrmChooseAccount frmIlkSayfa = new FrmChooseAccount();
            frmIlkSayfa.Show();
            this.Hide();
        }
    }
}
