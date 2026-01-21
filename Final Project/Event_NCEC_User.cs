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
    public partial class Event_NCEC_User : Form
    {
        public Event_NCEC_User()
        {
            InitializeComponent();
        }

        private void cross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Goback_Click(object sender, EventArgs e)
        {
            NSUuser nsuuser = new NSUuser();
            nsuuser.Show();
            this.Hide();
        }

        private void RegistrationNCEC1_Click(object sender, EventArgs e)
        {
            Registration_Form_NCEC_1 Registration_Form_NCEC_1 = new Registration_Form_NCEC_1();
            Registration_Form_NCEC_1.ShowDialog();
        }

        private void RegistrationNCEC2_Click(object sender, EventArgs e)
        {
            Registration_Form_NCEC_2 Registration_Form_NCEC_2 = new Registration_Form_NCEC_2();
            Registration_Form_NCEC_2.ShowDialog();
        }
    }
}
