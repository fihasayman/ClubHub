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
    public partial class President_ABC_Event : Form
    {
        public President_ABC_Event()
        {
            InitializeComponent();
        }

        private void Applicant_Click(object sender, EventArgs e)
        {
            President_ABC_App applicant = new President_ABC_App();
            applicant.Show();
            this.Hide();
        }

        private void Member_Click(object sender, EventArgs e)
        {
            President_ABC_Mem Event = new President_ABC_Mem();
            Event.Show();
            this.Hide();
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

        private void Add_Event2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is currently unavailable.");
        }

        private void Edit2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is currently unavailable.");
        }

        private void EditABC_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is currently unavailable.");
        }

        private void Activity_ABC_1_Click(object sender, EventArgs e)
        {
            Activity_ABC Activity_ABC = new Activity_ABC();
            Activity_ABC.Show();
            this.Hide();
        }

        private void Activity_ABC_2_Click(object sender, EventArgs e)
        {
            Activity_ABC_2 activity_ABC_2 = new Activity_ABC_2();
            activity_ABC_2.Show();
            this.Hide();
        }
    }

}
