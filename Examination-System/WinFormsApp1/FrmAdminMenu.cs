using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FrmAdminMenu : Form
    {
        public FrmAdminMenu()
        {
            InitializeComponent();
        }

        private void SoruOnaylaBoxBTN_Click(object sender, EventArgs e)
        {
            FrmQuestionConfirmation frmQuestionConfirmation = new FrmQuestionConfirmation();
            frmQuestionConfirmation.Show();
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
