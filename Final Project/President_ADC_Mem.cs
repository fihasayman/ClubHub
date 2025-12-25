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
    public partial class President_ADC_Mem : Form
    {
        public President_ADC_Mem()
        {
            InitializeComponent();
        }

        private void Applicant_Click(object sender, EventArgs e)
        {
            President_ADC_App applicant = new President_ADC_App();
            applicant.Show();
            this.Hide();
        }

        private void Event_Click(object sender, EventArgs e)
        {
            President_ADC_Event Event = new President_ADC_Event();
            Event.Show();
            this.Hide();
        }

        private void Goback_Click(object sender, EventArgs e)
        {
            AIUBclub clubPanel = new AIUBclub();
            clubPanel.Show();
            this.Hide();
        }

        private void cross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            AIUBclub clubPanel = new AIUBclub();
            clubPanel.Show();
            this.Hide();
        }
    }
}
