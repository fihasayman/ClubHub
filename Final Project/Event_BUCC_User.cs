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
    public partial class Event_BUCC_User : Form
    {
        public Event_BUCC_User()
        {
            InitializeComponent();
        }

        private void RegistrationBUCC1_Click(object sender, EventArgs e)
        {
            Registration_Form_BUCC_1 Registration_Form_BUCC_1 = new Registration_Form_BUCC_1();
            Registration_Form_BUCC_1.ShowDialog();
        }

        private void RegistrationBUCC2_Click(object sender, EventArgs e)
        {
            Registration_Form_BUCC_2 Registration_Form_BUCC_2 = new Registration_Form_BUCC_2();
            Registration_Form_BUCC_2.ShowDialog();
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
