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
    public partial class President_YES_Event : Form
    {
        public President_YES_Event()
        {
            InitializeComponent();
        }

        private void Member_YES_Click(object sender, EventArgs e)
        {
            President_YES_Mem member = new President_YES_Mem();
            member.Show();
            this.Hide();
        }

        private void Applicant_YES_Click(object sender, EventArgs e)
        {
            President_YES_App president_YES_App = new President_YES_App();
            president_YES_App.Show();
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

        private void Edit_YES_1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is currently unavailable.");

        }

        private void Edit_YES_2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is currently unavailable.");

        }

        private void Edit_YES_3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is currently unavailable.");

        }

        private void Activity_NYES_1_Click(object sender, EventArgs e)
        {
            Activity_NYES_1 activity_NYES_1 = new Activity_NYES_1();
            activity_NYES_1.Show();
            this.Hide();
        }

        private void Activity_NYES_2_Click(object sender, EventArgs e)
        {
            Activity_NYES_2 activity_NYES_2 = new Activity_NYES_2();
            activity_NYES_2.Show();
            this.Hide();
        }

        private void Activity_NYES_3_Click(object sender, EventArgs e)
        {
            Activity_NYES_3 activity_NYES_3 = new Activity_NYES_3();
            activity_NYES_3.Show();
            this.Hide();
        }
    }
}
