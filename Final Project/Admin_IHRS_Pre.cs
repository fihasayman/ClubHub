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
    public partial class Admin_IHRS_Pre : Form
    {
        public Admin_IHRS_Pre()
        {
            InitializeComponent();
        }

        private void IAA_Pre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("IUB University Accounting's Association Club President access is not available at the moment.");
        }

        private void IPC_Pre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("IUB University Photography Club President access is not available at the moment.");
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

        private void IMA_Pre_Click(object sender, EventArgs e)
        {
            Admin_Control_IUB admin_Control_IUB = new Admin_Control_IUB();
            admin_Control_IUB.Show();
            this.Hide();
        }
    }
}
