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
    public partial class President_BUCC_Event : Form
    {
        public President_BUCC_Event()
        {
            InitializeComponent();
        }

        private void Add_Event_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is currently unavailable.");
        }

        private void Member_Click(object sender, EventArgs e)
        {
            President_BUCC_Mem president_BUCC_Mem = new President_BUCC_Mem();
            president_BUCC_Mem.Show();
            this.Hide();
        }

        private void Applicant_Click(object sender, EventArgs e)
        {
            President_BUCC_app buac_App = new President_BUCC_app();
            buac_App.Show();
            this.Hide();
        }

        private void Edit2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is currently unavailable.");

        }

        private void Activity_BUCC_1_Click(object sender, EventArgs e)
        {
            Activity_BUCC_1 activity_BUCC_1 = new Activity_BUCC_1();
            activity_BUCC_1.Show();
            this.Hide();
        }

        private void Edit1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is currently unavailable.");

        }

        private void Edit1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is currently unavailable.");

        }

        private void Goback_Click(object sender, EventArgs e)
        {
            BRACclub clubPanel = new BRACclub();
            clubPanel.Show();
            this.Hide();
        }

        private void cross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Activity_BUCC_2_Click(object sender, EventArgs e)
        {
            Activity_BUCC_2 activity_BUCC_2 = new Activity_BUCC_2();
            activity_BUCC_2.Show();
            this.Hide();
        }
    }
}
