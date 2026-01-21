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
    public partial class Event_ABC_User : Form
    {
        public Event_ABC_User()
        {
            InitializeComponent();
        }

        private void Goback_Click(object sender, EventArgs e)
        {
            AIUBuser aiubuser = new AIUBuser();
            aiubuser.Show();
            this.Hide();
        }

        private void cross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegistrationABC1_Click(object sender, EventArgs e)
        {
            Registration_Form_ABC_1 Registration_Form_ABC_1 = new Registration_Form_ABC_1();
            Registration_Form_ABC_1.ShowDialog();
        }

        private void RegistrationABC2_Click(object sender, EventArgs e)
        {
            Registration_Form_ABC_2 Registration_Form_ABC_2 = new Registration_Form_ABC_2();
            Registration_Form_ABC_2.ShowDialog();
        }
    }
}
