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
    public partial class President_BUAC_Event : Form
    {
        public President_BUAC_Event()
        {
            InitializeComponent();
        }

        private void cross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Member_BUAC_Click(object sender, EventArgs e)
        {
            President_BUAC_Mem member = new President_BUAC_Mem();
            member.Show();
            this.Hide();
        }

        private void Applicant_BUAC_Click(object sender, EventArgs e)
        {
            President_BUAC_App applicant = new President_BUAC_App();
            applicant.Show();
            this.Hide();
        }

        private void Goback_Click(object sender, EventArgs e)
        {
            BRACclub clubPanel = new BRACclub();
            clubPanel.Show();
            this.Hide();
        }

        private void Add_Event_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is currently unavailable.");
        }

        private void EditBUAC1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is currently unavailable.");

        }

        private void EditBUAC2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is currently unavailable.");

        }

        private void EditBUAC3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is currently unavailable.");

        }

        private void Activity_BUAC_1_Click(object sender, EventArgs e)
        {
            Activity_BUAC_1 activity_BUAC_1 = new Activity_BUAC_1();
            activity_BUAC_1.Show();
            this.Hide();
        }

        private void Activity_BUAC_2_Click(object sender, EventArgs e)
        {
            Activity_BUAC_2 activity_BUAC_2 = new Activity_BUAC_2();
            activity_BUAC_2.Show();
            this.Hide();
        }

        private void Activity_BUAC_3_Click(object sender, EventArgs e)
        {
            Activity_BUAC_3 activity_BUAC_3 = new Activity_BUAC_3();
            activity_BUAC_3.Show();
            this.Hide();
        }
    }
}
