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
    public partial class President_ADC_Event : Form
    {
        public President_ADC_Event()
        {
            InitializeComponent();
        }

        private void cross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Applicant_Click(object sender, EventArgs e)
        {
            President_ADC_App applicant = new President_ADC_App();
            applicant.Show();
            this.Hide();
        }

        private void Member_Click(object sender, EventArgs e)
        {
            President_ADC_Mem applicant = new President_ADC_Mem();
            applicant.Show();
            this.Hide();
        }

        private void Goback_Click(object sender, EventArgs e)
        {
            AIUBclub clubPanel = new AIUBclub();
            clubPanel.Show();
            this.Hide();
        }

        private void Add_Event_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is currently unavailable.");
        }

        private void AddPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EditADC_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is currently unavailable.");
        }

        private void Edit2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is currently unavailable.");
        }

        private void Activity_ADC_1_Click(object sender, EventArgs e)
        {
            Activity_ADC_1 activity_ADC_1 = new Activity_ADC_1();
            activity_ADC_1.Show();
            this.Hide();
        }

        private void Activity_ADC2_Click(object sender, EventArgs e)
        {
            Activity_ADC_2 activity_ADC_2 = new Activity_ADC_2();
            activity_ADC_2.Show();
            this.Hide();
        }

        private void President_ADC_Event_Load(object sender, EventArgs e)
        {

        }
    }
}
