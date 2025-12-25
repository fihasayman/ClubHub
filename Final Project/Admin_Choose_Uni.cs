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
    public partial class Admin_Choose_Uni : Form
    {
        public Admin_Choose_Uni()
        {
            InitializeComponent();
        }

        private void cross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Goback_Click(object sender, EventArgs e)
        {
            Profile adminProfile = new Profile();
            adminProfile.Show();
            this.Hide();
        }

        private void Admin_AIUB_Click(object sender, EventArgs e)
        {
            Admin_Control_AIUB adminAIUB = new Admin_Control_AIUB();
            adminAIUB.Show();
            this.Hide();
        }

        private void Admin_BRAC_Click(object sender, EventArgs e)
        {
            Admin_Control_BRAC adminBRAC = new Admin_Control_BRAC();
            adminBRAC.Show();
            this.Hide();
        }

        private void Admin_IUB_Click(object sender, EventArgs e)
        {
            Admin_Control_IUB adminIUB = new Admin_Control_IUB();
            adminIUB.Show();
            this.Hide();
        }

        private void Admin_NSU_Click(object sender, EventArgs e)
        {
            Admin_Control_NSU adminNSU = new Admin_Control_NSU();
            adminNSU.Show();
            this.Hide();
        }
    }
}
