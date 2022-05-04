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

        private void sinaviOlusturBTN_Click(object sender, EventArgs e)
        {
            IQuestionService questionManager = new QuestionManager();
            BaseResult<List<Question>> result=questionManager.RandomQuestion();
            if(result.data.Count==0)
            {
                MessageBox.Show("Sorular bulunamadı");
            }
            else
            {
                MessageBox.Show("Sorular hazırlandı");
            }
        }
    }
}
