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
        FrmIlkSayfa frmIlkSayfa = new FrmIlkSayfa();

        private UserType userType;

        private IAuthService _authService = new AuthManager();

        public FrmLogin(UserType userType)
        {
            InitializeComponent();
            this.userType = userType;
        }

        private void kayıtOlBTN_Click(object sender, EventArgs e)
        {
            FrmRegister frmKayit = new FrmRegister(this.userType);
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
            IAuthService authService = new AuthManager();
            User _user;
            if(this.userType==UserType.ADMIN)
            {
                _user =new AdminAccount();
                _user.UserName = kullaniciAdiTxt.Text;
                _user.Password = sifreTxt.Text;
                FrmQuestionConfirmation frmQuestionConfirmation = new FrmQuestionConfirmation();
                frmQuestionConfirmation.Show();
                this.Hide();
            }
            else if(this.userType==UserType.EXAMINER)
            {
                _user = new ExaminerAccount();
                _user.UserName = kullaniciAdiTxt.Text;
                _user.Password = sifreTxt.Text;
                KodNoLbl frmSinavHazirlamaModülü = new KodNoLbl();
                frmSinavHazirlamaModülü.Show();
                this.Hide();
            }
            else
            {
                _user = new MusteriAccount();
                _user.UserName = kullaniciAdiTxt.Text;
                _user.Password = sifreTxt.Text;
            }
            BaseResult<User> result= authService.Login(_user, this.userType);
            if(!result.isSuccess)
            {
                MessageBox.Show("Hatalı");
            }
            else
            {
                //kullanıcı verilerini çekmek için
            }

        }
    }
}
