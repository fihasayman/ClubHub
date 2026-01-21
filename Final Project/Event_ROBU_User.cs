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
    public partial class Event_ROBU_User : Form
    {
        public Event_ROBU_User()
        {
            InitializeComponent();
        }

        private void RegistrationROBU1_Click(object sender, EventArgs e)
        {
            Registration_Form_ROBU_1 Registration_Form_ROBU_1 = new Registration_Form_ROBU_1();
            Registration_Form_ROBU_1.ShowDialog();
        }

        private void Registration_ROBU_2_Click(object sender, EventArgs e)
        {
            Registration_Form_ROBU_2 Registration_Form_ROBU_2 = new Registration_Form_ROBU_2();
            Registration_Form_ROBU_2.ShowDialog();
        }

        private void Goback_Click(object sender, EventArgs e)
        {
            BRACuser bracuser = new BRACuser();
            bracuser.Show();
            this.Hide();
        }
    }
}
