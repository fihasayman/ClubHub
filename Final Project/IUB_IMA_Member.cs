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
    public partial class IUB_IMA_Member : Form
    {
        public IUB_IMA_Member()
        {
            InitializeComponent();
        }

        private void cross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Goback_Click(object sender, EventArgs e)
        {
            IUBClub IUB = new IUBClub();
            IUB.Show();
            this.Hide();
        }

        private void Volunteer_IMA_1_Click(object sender, EventArgs e)
        {
            Volunteer_Form_IMA_1 volunteer_Form_IMA_1 = new Volunteer_Form_IMA_1();
            volunteer_Form_IMA_1.ShowDialog();
        }

        private void Volunteer_IMA_2_Click(object sender, EventArgs e)
        {
            Volunteer_Form_IMA_2 volunteer_Form_IMA_2 = new Volunteer_Form_IMA_2();
            volunteer_Form_IMA_2.ShowDialog();
        }

        private void Registration_IMA_1_Click(object sender, EventArgs e)
        {
            Registration_Form_IMA_1 registration_Form_IMA_1 = new Registration_Form_IMA_1();
            registration_Form_IMA_1.ShowDialog();
        }

        private void Registration_IMA_2_Click(object sender, EventArgs e)
        {
            Registration_Form_IMA_2 registration_Form_IMA_2 = new Registration_Form_IMA_2();
            registration_Form_IMA_2.ShowDialog();
        }
    }
}
