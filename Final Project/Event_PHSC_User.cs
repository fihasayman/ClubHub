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
    public partial class Event_PHSC_User : Form
    {
        public Event_PHSC_User()
        {
            InitializeComponent();
        }

        private void Goback_Click(object sender, EventArgs e)
        {
            NSUuser user = new NSUuser();
            user.Show();
            this.Hide();
        }

        private void cross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegistrationNPHSC1_Click(object sender, EventArgs e)
        {
            Registration_Form_PHSC_1 Registration_Form_PHSC_1 = new Registration_Form_PHSC_1();
            Registration_Form_PHSC_1.ShowDialog();
        }

        private void RegistrationNPHSC2_Click(object sender, EventArgs e)
        {
            Registration_Form_PHSC_2 Registration_PHSC_2 = new Registration_Form_PHSC_2();
            Registration_PHSC_2.ShowDialog();
        }
    }
}
