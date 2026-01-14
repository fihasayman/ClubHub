using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Admin_Control_BUCC : Form
    {
        public Admin_Control_BUCC()
        {
            InitializeComponent();
        }

        private void cross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Profile adminProfile = new Profile();
            adminProfile.Show();
            this.Hide();
        }

        private void Goback_Click(object sender, EventArgs e)
        {
            Admin_Choose_Uni adminChooseUni = new Admin_Choose_Uni();
            adminChooseUni.Show();
            this.Hide();
        }

        private void BUBC_Pre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BRAC University Business Club President access is not available at the moment.");
        }

        private void BUAC_Pre_Click(object sender, EventArgs e)
        {
            Admin_Control_BUAC BUCCAdmin = new Admin_Control_BUAC();
            BUCCAdmin.Show();
            this.Hide();
        }

        private void ROBU_Pre_Click(object sender, EventArgs e)
        {
            Admin_Control_BRAC BUCCAdmin = new Admin_Control_BRAC();
            BUCCAdmin.Show();
            this.Hide();
        }
    }
}
