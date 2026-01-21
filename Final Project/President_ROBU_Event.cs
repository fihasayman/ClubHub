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
    public partial class President_ROBU_Event : Form
    {
        public President_ROBU_Event()
        {
            InitializeComponent();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void cross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Goback_Click(object sender, EventArgs e)
        {
            BRACclub clubPanel = new BRACclub();
            clubPanel.Show();
            this.Hide();
        }

        private void President_ROBU_Event_Load(object sender, EventArgs e)
        {

        }

        private void RegistrationROBU1_Click(object sender, EventArgs e)
        {
            Activity_ROBU_1 activity_ROBU_1 = new Activity_ROBU_1();
            activity_ROBU_1.Show();
            this.Hide();
        }

        private void Activity_ROBU_1_Click(object sender, EventArgs e)
        {
            Activity_ROBU_1 activity_ROBU_1 = new Activity_ROBU_1();
            activity_ROBU_1.Show();
            this.Hide();
        }

        private void Activity_ROBU_2_Click(object sender, EventArgs e)
        {
            Activity_ROBU_2 activity_ROBU_2 = new Activity_ROBU_2();
            activity_ROBU_2.Show();
            this.Hide();
        }

        private void Member_ROBU_Click(object sender, EventArgs e)
        {
            President_ROBU_Mem president_ROBU_Mem = new President_ROBU_Mem();
            president_ROBU_Mem.Show();
            this.Hide();
        }

        private void Applicant_ROBU_Click(object sender, EventArgs e)
        {
            President_ROBU_App applicant = new President_ROBU_App();
            applicant.Show();
            this.Hide();
        }

        private void Add_Event_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is currently unavailable.");
        }

        private void EditROBU1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is currently unavailable.");

        }

        private void Edit2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is currently unavailable.");

        }



        private void Add_Event_Click_2(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is currently unavailable");
        }
    }
}
