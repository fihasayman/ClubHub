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
    public partial class NSUuser : Form
    {
        public NSUuser()
        {
            InitializeComponent();
        }

        private void cross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Goback_Click(object sender, EventArgs e)
        {
            userchoseuni user = new userchoseuni();
            user.Show();
            this.Hide();
        }

        private void JoinACC_Click(object sender, EventArgs e)
        {
            Session.University = "NSU";
            Session.Club = "YES";
            Registration regForm = new Registration();
            regForm.Show();
            this.Hide();
        }

        private void JoinABC_Click(object sender, EventArgs e)
        {
            Session.University = "NSU";
            Session.Club = "PHSC";
            Registration regForm = new Registration();
            regForm.Show();
            this.Hide();
        }

        private void JoinADC_Click(object sender, EventArgs e)
        {
            Session.University = "NSU";
            Session.Club = "CEC";
            Registration regForm = new Registration();
            regForm.Show();
            this.Hide();
        }

        private void JoinARND_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Club is currently inactive.");
        }

        private void Event_APC_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Club is currently inactive, it has nothing to show");
        }

        private void Event_YES_Click(object sender, EventArgs e)
        {
            Event_NYES_User event_NYES_User = new Event_NYES_User();
            event_NYES_User.Show();
            this.Hide();
        }

        private void Event_PHSC_Click(object sender, EventArgs e)
        {
            Event_PHSC_User event_PHSC_user = new Event_PHSC_User();
            event_PHSC_user.Show();
            this.Hide();
        }

        private void Event_CEC_Click(object sender, EventArgs e)
        {
            Event_NCEC_User event_CEC_user = new Event_NCEC_User();
            event_CEC_user.Show();
            this.Hide();
        }

        private void NSUuser_Load(object sender, EventArgs e)
        {

        }
    }
}
