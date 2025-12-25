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
    public partial class Admin_NPHSC_Pre : Form
    {
        public Admin_NPHSC_Pre()
        {
            InitializeComponent();
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

        private void NCEC_Pre_Click(object sender, EventArgs e)
        {
            Admin_NCEC_Pre NCECPre = new Admin_NCEC_Pre();
            NCECPre.Show();
            this.Hide();
        }

        private void NAPC_Pre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NSU Art And Photography Club President access is not available at the moment.");
        }

        private void NYES_Pre_Click(object sender, EventArgs e)
        {
            Admin_Control_NSU NCECPre = new Admin_Control_NSU();
            NCECPre.Show();
            this.Hide();
        }

        private void cross_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
