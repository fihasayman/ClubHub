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
    public partial class Event_IMA_User : Form
    {
        public Event_IMA_User()
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

        private void RegistrationIMA1_Click(object sender, EventArgs e)
        {
            Registration_Form_IMA_1 Registration_Form_IMA_1 = new Registration_Form_IMA_1();
            Registration_Form_IMA_1.ShowDialog();
        }

        private void RegistrationIMA2_Click(object sender, EventArgs e)
        {
            Registration_Form_IMA_2 Registration_Form_IMA_2 = new Registration_Form_IMA_2();
            Registration_Form_IMA_2.ShowDialog();
        }
    }
}
