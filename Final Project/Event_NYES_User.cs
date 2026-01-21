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
    public partial class Event_NYES_User : Form
    {
        public Event_NYES_User()
        {
            InitializeComponent();
        }

        private void RegistrationNYES1_Click(object sender, EventArgs e)
        {
            Registration_Form_NYES_1 registration_Form_NYES_1 = new Registration_Form_NYES_1();
            registration_Form_NYES_1.ShowDialog();
        }

        private void RegistrationNYES2_Click(object sender, EventArgs e)
        {
            Registration_Form_NYES_2 registration_Form_NYES_2 = new Registration_Form_NYES_2();
            registration_Form_NYES_2.ShowDialog();
        }

        private void RegistrationNYES3_Click(object sender, EventArgs e)
        {
            Registration_Form_NYES_3 registration_Form_NYES_3 = new Registration_Form_NYES_3();
            registration_Form_NYES_3.ShowDialog();
        }

        private void Goback_Click(object sender, EventArgs e)
        {
            NSUuser nsuuser = new NSUuser();
            nsuuser.Show();
            this.Hide();
        }

        private void cross_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
