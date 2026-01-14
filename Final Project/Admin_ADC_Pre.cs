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
    public partial class Admin_ADC_Pre : Form
    {
        public Admin_ADC_Pre()
        {
            InitializeComponent();
        }

        private void ARND_Pre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ARND Club President Control is not available yet.");
        }

        private void ACC_Pre_Click(object sender, EventArgs e)
        {
            Admin_Control_AIUB ACCPre = new Admin_Control_AIUB();
            ACCPre.Show();
            this.Hide();
        }

        private void ABC_Pre_Click(object sender, EventArgs e)
        {
            Admin_ABC_Pre ABCPre = new Admin_ABC_Pre();
            ABCPre.Show();
            this.Hide();
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
    }
}
