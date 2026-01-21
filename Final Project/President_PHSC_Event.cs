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
    public partial class President_PHSC_Event : Form
    {
        public President_PHSC_Event()
        {
            InitializeComponent();
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

        private void Member_PHSC_Click(object sender, EventArgs e)
        {
            President_PHSC_Mem president_PHSC_Mem = new President_PHSC_Mem();
            president_PHSC_Mem.Show();
            this.Hide();
        }

        private void Applicant_PHSC_Click(object sender, EventArgs e)
        {
            President_PHSC_App president_PHSC_App = new President_PHSC_App();
            president_PHSC_App.Show();
            this.Hide();
        }

        private void Add_Event_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is currently unavailable.");
        }

        private void Edit_NPHSC_1_Click(object sender, EventArgs e)
        {
            Edit_Event_NPHSC_1 edit_Event_NPHSC_1 = new Edit_Event_NPHSC_1();
            edit_Event_NPHSC_1.ShowDialog();
        }

        private void Edit_NPHSC_2_Click(object sender, EventArgs e)
        {
            Edit_Event_NPHSC_2 edit_Event_NPHSC_2 = new Edit_Event_NPHSC_2();
            edit_Event_NPHSC_2.ShowDialog();
        }

        private void Activity_NPHSC_1_Click(object sender, EventArgs e)
        {
            Activity_NPHSC_1 activity_NPHSC_1 = new Activity_NPHSC_1();
            activity_NPHSC_1.Show();
            this.Hide();
        }

        private void Activity_NPHSC_2_Click(object sender, EventArgs e)
        {
            Activity_NPHSC_2 activity_NPHSC_2 = new Activity_NPHSC_2();
            activity_NPHSC_2.Show();
            this.Hide();
        }
    }
}
