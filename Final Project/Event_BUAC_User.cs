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
    public partial class Event_BUAC_User : Form
    {
        public Event_BUAC_User()
        {
            InitializeComponent();
        }

        private void RegistrationBUAC1_Click(object sender, EventArgs e)
        {
            Registration_Form_BUAC_1 Registration_Form_BUAC_1 = new Registration_Form_BUAC_1();
            Registration_Form_BUAC_1.ShowDialog();
        }

        private void RegistrationBUAC2_Click(object sender, EventArgs e)
        {
            Registration_Form_BUAC_2 Registration_Form_BUAC_2 = new Registration_Form_BUAC_2();
            Registration_Form_BUAC_2.ShowDialog();
        }

        private void RegistrationBUAC3_Click(object sender, EventArgs e)
        {
            Registration_Form_BUAC_3 Registration_Form_BUAC_3 = new Registration_Form_BUAC_3();
            Registration_Form_BUAC_3.ShowDialog();
        }

        private void cross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Goback_Click(object sender, EventArgs e)
        {
            BRACuser bracuser = new BRACuser();
            bracuser.Show();
            this.Hide();
        }
    }
}
