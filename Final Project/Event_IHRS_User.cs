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
    public partial class Event_IHRS_User : Form
    {
        public Event_IHRS_User()
        {
            InitializeComponent();
        }

        private void cross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Goback_Click(object sender, EventArgs e)
        {
            IUBuser iubuser = new IUBuser();
            iubuser.Show();
            this.Hide();
        }

        private void RegistrationIHRS1_Click(object sender, EventArgs e)
        {
            Registration_Form_IHRS_1 Registration_Form_IHRS_1 = new Registration_Form_IHRS_1();
            Registration_Form_IHRS_1.ShowDialog();
        }

        private void RegistrationIHRS2_Click(object sender, EventArgs e)
        {
            Registration_Form_IHRS_2 Registration_Form_IHRS_2 = new Registration_Form_IHRS_2();
            Registration_Form_IHRS_2.ShowDialog();
        }

        private void RegistrationIHRS3_Click(object sender, EventArgs e)
        {
            Registration_Form_IHRS_3 Registration_Form_IHRS_3 = new Registration_Form_IHRS_3();
            Registration_Form_IHRS_3.ShowDialog();
        }
    }
}
