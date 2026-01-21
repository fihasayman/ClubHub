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
    public partial class President_NCEC_Event : Form
    {
        public President_NCEC_Event()
        {
            InitializeComponent();
        }

        private void Member_NCEC_Click(object sender, EventArgs e)
        {
            President_CEC_Mem member = new President_CEC_Mem();
            member.Show();
            this.Hide();
        }

        private void Applicant_NCEC_Click(object sender, EventArgs e)
        {
            President_NCEC_App applicant = new President_NCEC_App();
            applicant.Show();
            this.Hide();
        }

        private void cross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Goback_Click(object sender, EventArgs e)
        {
            NSUclub clubPanel = new NSUclub();
            clubPanel.Show();
            this.Hide();
        }

        private void Add_Event_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is currently unavailable.");
        }

        private void Edit_NCEC_1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is currently unavailable.");

        }

        private void Edit_NCEC_2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is currently unavailable.");

        }

        private void Activity_NCEC_1_Click(object sender, EventArgs e)
        {
            Activity_NCEC_1 activity_NCEC_1 = new Activity_NCEC_1();
            activity_NCEC_1.Show();
            this.Hide();
        }

        private void Activity_NCEC_2_Click(object sender, EventArgs e)
        {
            Activity_NCEC_2 activity_NCEC_2 = new Activity_NCEC_2();
            activity_NCEC_2.Show();
            this.Hide();
        }
    }
}
