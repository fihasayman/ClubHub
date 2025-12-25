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
    public partial class Admin_Control_NSU : Form
    {
        public Admin_Control_NSU()
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

        private void NPHSC_Pre_Click(object sender, EventArgs e)
        {
            Admin_NPHSC_Pre NPHSCPre = new Admin_NPHSC_Pre();
            NPHSCPre.Show();
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

        private void cross_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
