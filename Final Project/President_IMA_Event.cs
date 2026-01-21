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
    public partial class President_IMA_Event : Form
    {
        public President_IMA_Event()
        {
            InitializeComponent();
        }

        private void Applicant_IMA_Click(object sender, EventArgs e)
        {
            President_IMA_App imaapp = new President_IMA_App();
            imaapp.Show();
            this.Hide();
        }

        private void Member_IMA_Click(object sender, EventArgs e)
        {
            President_IMA_Mem imaMem = new President_IMA_Mem();
            imaMem.Show();
            this.Hide();
        }

        private void cross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Goback_Click(object sender, EventArgs e)
        {
            IUBClub clubPanel = new IUBClub();
            clubPanel.Show();
            this.Hide();
        }

        private void Add_Event_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is currently unavailable.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is currently unavailable.");

        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is currently unavailable.");

        }

        private void Activity_IMA_1_Click(object sender, EventArgs e)
        {
            Activity_IMA_1 activity_IMA_1 = new Activity_IMA_1();
            activity_IMA_1.Show();
            this.Hide();
        }

        private void Activity_IMA_2_Click(object sender, EventArgs e)
        {
            Activity_IMA_2 activity_IMA_2 = new Activity_IMA_2();
            activity_IMA_2.Show();
            this.Hide();
        }
    }
}
