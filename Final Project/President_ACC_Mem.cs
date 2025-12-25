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
    public partial class President_ACC_Mem : Form
    {
        public President_ACC_Mem()
        {
            InitializeComponent();
        }

        private void cross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Goback_Click(object sender, EventArgs e)
        {
            AIUBclub clubPanel = new AIUBclub();
            clubPanel.Show();
            this.Hide();
        }

        private void Applicant_Click(object sender, EventArgs e)
        {
            President_ACC_App applicant = new President_ACC_App();
            applicant.Show();
            this.Hide();
        }

        private void Event_Click(object sender, EventArgs e)
        {
            President_ACC_Event Event = new President_ACC_Event();
            Event.Show();
            this.Hide();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
