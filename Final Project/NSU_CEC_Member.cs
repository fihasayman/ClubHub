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
    public partial class NSU_CEC_Member : Form
    {
        public NSU_CEC_Member()
        {
            InitializeComponent();
        }

        private void cross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Goback_Click(object sender, EventArgs e)
        {
            NSUclub NSU = new NSUclub();
            NSU.Show();
            this.Hide();
        }

        private void Volunteer_NCEC_1_Click(object sender, EventArgs e)
        {
            Volunteer_Form_NCEC_1 volunteer_Form_NCEC_1 = new Volunteer_Form_NCEC_1();
            volunteer_Form_NCEC_1.ShowDialog();
        }

        private void Volunteer_NCEC_2_Click(object sender, EventArgs e)
        {
            Volunteer_Form_NCEC_2 volunteer_Form_NCEC_2 = new Volunteer_Form_NCEC_2();
            volunteer_Form_NCEC_2.ShowDialog();
        }

        private void Registration_NCEC_1_Click(object sender, EventArgs e)
        {
            Registration_Form_NCEC_1 registration_Form_NCEC_1 = new Registration_Form_NCEC_1();
            registration_Form_NCEC_1.ShowDialog();
        }

        private void Registration_NCEC_2_Click(object sender, EventArgs e)
        {
            Registration_Form_NCEC_2 registration_Form_NCEC_2 = new Registration_Form_NCEC_2();
            registration_Form_NCEC_2.ShowDialog();
        }
    }
}
