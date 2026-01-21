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
    public partial class AIUB_ABC_Member : Form
    {
        public AIUB_ABC_Member()
        {
            InitializeComponent();
        }

        private void Goback_Click(object sender, EventArgs e)
        {
            AIUBclub clubPanel = new AIUBclub();
            clubPanel.Show();
            this.Hide();
        }

        private void cross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Volunteer_ABC_1_Click(object sender, EventArgs e)
        {
            Volunteer_Form_ABC_1 volunteerForm1 = new Volunteer_Form_ABC_1();
            volunteerForm1.ShowDialog();

        }

        private void Volunteer_ABC_2_Click(object sender, EventArgs e)
        {
            Volunteer_Form_ABC_2 volunteerForm2 = new Volunteer_Form_ABC_2();
            volunteerForm2.ShowDialog();
        }

        private void Registration_ABC_1_Click(object sender, EventArgs e)
        {
            Registration_Form_ABC_1 registrationForm1 = new Registration_Form_ABC_1();
            registrationForm1.ShowDialog();
        }

        private void Registration_ABC_2_Click(object sender, EventArgs e)
        {
            Registration_Form_ABC_2 registrationForm2 = new Registration_Form_ABC_2();
            registrationForm2.ShowDialog();
        }
    }
}
