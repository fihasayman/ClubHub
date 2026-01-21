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
    public partial class IUB_IHRS_Member : Form
    {
        public IUB_IHRS_Member()
        {
            InitializeComponent();
        }

        private void cross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Goback_Click(object sender, EventArgs e)
        {
            IUBClub IUB = new IUBClub();
            IUB.Show();
            this.Hide();
        }

        private void Volunteer_IHRS_2_Click(object sender, EventArgs e)
        {
            Volunteer_Form_IHRS_1 volunteer_Form_IHRS_1 = new Volunteer_Form_IHRS_1();
            volunteer_Form_IHRS_1.ShowDialog();
        }

        private void Volunteer_IHRS_1_Click(object sender, EventArgs e)
        {
            Volunteer_Form_IHRS_2 volunteer_Form_IHRS_2 = new Volunteer_Form_IHRS_2();
            volunteer_Form_IHRS_2.ShowDialog();
        }

        private void Volunteer_IHRS_3_Click(object sender, EventArgs e)
        {
            Volunteer_Form_IHRS_3 volunteer_Form_IHRS_3 = new Volunteer_Form_IHRS_3();
            volunteer_Form_IHRS_3.ShowDialog();
        }

        private void Registration_IHRS_1_Click(object sender, EventArgs e)
        {
            Registration_Form_IHRS_1 registration_Form_IHRS_1 = new Registration_Form_IHRS_1();
            registration_Form_IHRS_1.ShowDialog();
        }

        private void Registration_IHRS_2_Click(object sender, EventArgs e)
        {
            Registration_Form_IHRS_2 registration_Form_IHRS_2 = new Registration_Form_IHRS_2();
            registration_Form_IHRS_2.ShowDialog();
        }

        private void Registration_IHRS_3_Click(object sender, EventArgs e)
        {
            Registration_Form_IHRS_3 registration_Form_IHRS_3 = new Registration_Form_IHRS_3();
            registration_Form_IHRS_3.ShowDialog();
        }
    }
}
