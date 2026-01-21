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
    public partial class NSU_PHSC_Member : Form
    {
        public NSU_PHSC_Member()
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

        private void Volunteer_NPHSC_1_Click(object sender, EventArgs e)
        {
            Volunteer_Form_NPHSC_1 volunteer_Form_NPHSC_1 = new Volunteer_Form_NPHSC_1();
            volunteer_Form_NPHSC_1.ShowDialog();
        }

        private void Volunteer_NPHSC_2_Click(object sender, EventArgs e)
        {
            Volunteer_Form_NPHSC_2 volunteer_Form_NPHSC_2 = new Volunteer_Form_NPHSC_2();
            volunteer_Form_NPHSC_2.ShowDialog();
        }

        private void Registration_PHSC_1_Click(object sender, EventArgs e)
        {
            Registration_Form_PHSC_1 registration_Form_PHSC_1 = new Registration_Form_PHSC_1();
            registration_Form_PHSC_1.ShowDialog();
        }

        private void Registration_PHSC_2_Click(object sender, EventArgs e)
        {
            Registration_Form_PHSC_2 registration_Form_PHSC_2 = new Registration_Form_PHSC_2();
            registration_Form_PHSC_2.ShowDialog();
        }
    }
}
