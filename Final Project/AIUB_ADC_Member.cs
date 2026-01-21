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
    public partial class AIUB_ADC_Member : Form
    {
        public AIUB_ADC_Member()
        {
            InitializeComponent();
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

        private void Volunteer_ADC_1_Click(object sender, EventArgs e)
        {
            Volunteer_Form_ADC_1 volunteerFormAdc1 = new Volunteer_Form_ADC_1();
            volunteerFormAdc1.ShowDialog();
        }

        private void Volunteer_ADC_2_Click(object sender, EventArgs e)
        {
            Volunteer_Form_ADC_2 volunteerFormAdc2 = new Volunteer_Form_ADC_2();
            volunteerFormAdc2.ShowDialog();
        }

        private void Registration_ADC_1_Click(object sender, EventArgs e)
        {
            Registration_Form_ADC_1 registrationForm1 = new Registration_Form_ADC_1();
            registrationForm1.ShowDialog();
        }

        private void RegistrationADC2_Click(object sender, EventArgs e)
        {
            Registration_Form_ADC_2 registrationForm2 = new Registration_Form_ADC_2();
            registrationForm2.ShowDialog();
        }
    }
}
