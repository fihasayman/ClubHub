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
    public partial class President_IHRS_Event : Form
    {
        public President_IHRS_Event()
        {
            InitializeComponent();
        }

        private void Goback_Click(object sender, EventArgs e)
        {
            IUBClub clubPanel = new IUBClub();
            clubPanel.Show();
            this.Hide();
        }

        private void cross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Member_IHRS_Click(object sender, EventArgs e)
        {
            President_IHRS_Mem president_IHRS_Mem = new President_IHRS_Mem();
            president_IHRS_Mem.Show();
            this.Hide();
        }

        private void Applicant_Click(object sender, EventArgs e)
        {
            President_IHRS_App president_IHRS_App = new President_IHRS_App();
            president_IHRS_App.Show();
            this.Hide();
        }

        private void Add_Event_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is currently unavailable.");
        }

        private void Edit_IHRS_3_Click(object sender, EventArgs e)
        {
            Edit_Event_IHRS_3 edit_Event_IHRS_3 = new Edit_Event_IHRS_3();
            edit_Event_IHRS_3.ShowDialog();
        }

        private void Edit_IHRS_1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is currently unavailable.");

        }

        private void Edit_IHRS_2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is currently unavailable.");

        }

        private void Activity_IHRS_1_Click(object sender, EventArgs e)
        {
            Activity_IHRS_1 activity_IHRS_1 = new Activity_IHRS_1();
            activity_IHRS_1.Show();
            this.Hide();
        }

        private void Activity_IHRS_2_Click(object sender, EventArgs e)
        {
            Activity_IHRS_2 activity_IHRS_2 = new Activity_IHRS_2();
            activity_IHRS_2.Show();
            this.Hide();
        }

        private void Activity_IHRS_3_Click(object sender, EventArgs e)
        {
            Activity_IHRS_3 activity_IHRS_3 = new Activity_IHRS_3();
            activity_IHRS_3.Show();
            this.Hide();
        }
    }
}
