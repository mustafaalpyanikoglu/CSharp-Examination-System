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
    public partial class FrmIlkSayfa : Form
    {
        public bool isAdminMusteri;
        public FrmIlkSayfa()
        {
            InitializeComponent();
        }

        private void ogrenciBTN_Click(object sender, EventArgs e)
        {
            //Variables.test = false;
            
            FrmGiris frmGiris = new FrmGiris(UserType.CUSTOMER);
            frmGiris.Show();
            this.Hide();
        }

        private void AdminBTN_Click(object sender, EventArgs e)
        {
            //Variables.test = true;
            
            FrmGiris frmGiris = new FrmGiris(UserType.ADMIN);
            frmGiris.Show();
            this.Hide();
        }
    }
}
