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
    public partial class BRAC_BUCC_Member : Form
    {
        public BRAC_BUCC_Member()
        {
            InitializeComponent();
        }

        private void cross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Goback_Click(object sender, EventArgs e)
        {
            BRACclub brac = new BRACclub();
            brac.Show();
            this.Hide();
        }

        private void RegistrationBUCC1_Click(object sender, EventArgs e)
        {
            Registration_Form_BUCC_1 Registration_Form_BUCC_1 = new Registration_Form_BUCC_1();
            Registration_Form_BUCC_1.ShowDialog();
        }

        private void RegistrationBUCC2_Click(object sender, EventArgs e)
        {
            Registration_Form_BUCC_2 Registration_Form_BUCC_2 = new Registration_Form_BUCC_2();
            Registration_Form_BUCC_2.ShowDialog();
        }

        private void VolunteerBUCC1_Click(object sender, EventArgs e)
        {
            Volunteer_Form_BUCC_1 volunteer_Form_BUCC_1 = new Volunteer_Form_BUCC_1();
            volunteer_Form_BUCC_1.ShowDialog();
        }

        private void VolunteerBUCC2_Click(object sender, EventArgs e)
        {
            Volunteer_Form_BUCC_2 volunteer_Form_BUCC_2 = new Volunteer_Form_BUCC_2();
            volunteer_Form_BUCC_2.ShowDialog();
        }
    }
}
