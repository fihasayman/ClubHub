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
    public partial class BRAC_BUAC_Member : Form
    {
        public BRAC_BUAC_Member()
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

        private void Volunteer_BUAC_1_Click(object sender, EventArgs e)
        {
            Volunteer_Form_BUAC_1 volunteer_Form_BUAC_1 = new Volunteer_Form_BUAC_1();
            volunteer_Form_BUAC_1.ShowDialog();
        }

        private void Volunteer_BUAC_2_Click(object sender, EventArgs e)
        {
            Volunteer_Form_BUAC_2 volunteer_Form_BUAC_2 = new Volunteer_Form_BUAC_2();
            volunteer_Form_BUAC_2.ShowDialog();
        }

        private void Volunteer_BUAC_3_Click(object sender, EventArgs e)
        {
            Volunteer_Form_BUAC_3 volunteer_Form_BUAC_3 = new Volunteer_Form_BUAC_3();
            volunteer_Form_BUAC_3.ShowDialog();
        }

        private void Registration1_Click(object sender, EventArgs e)
        {
            Registration_Form_BUAC_1 Registration_Form_BUAC_1 = new Registration_Form_BUAC_1();
            Registration_Form_BUAC_1.ShowDialog();
        }

        private void Registration_BUAC_2_Click(object sender, EventArgs e)
        {
            Registration_Form_BUAC_2 Registration_Form_BUAC_2 = new Registration_Form_BUAC_2();
            Registration_Form_BUAC_2.ShowDialog();
        }

        private void RegistrationBUAC3_Click(object sender, EventArgs e)
        {
            Registration_Form_BUAC_3 Registration_Form_BUAC_3 = new Registration_Form_BUAC_3();
            Registration_Form_BUAC_3.ShowDialog();
        }
    }
}
