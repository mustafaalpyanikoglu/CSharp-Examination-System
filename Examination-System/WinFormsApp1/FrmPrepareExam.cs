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
    public partial class FrmPrepareExam : Form
    {
        public FrmPrepareExam()
        {
            InitializeComponent();
        }

        private void KapatBTN_Click(object sender, EventArgs e)
        {
            FrmAdminMenu frmAdminMenu = new FrmAdminMenu();
            frmAdminMenu.Show();
            this.Hide();
        }

        
    }
}
