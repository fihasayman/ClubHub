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
    public partial class BRACuser : Form
    {
        public BRACuser()
        {
            InitializeComponent();
        }

        private void Goback_Click(object sender, EventArgs e)
        {
            userchoseuni user = new userchoseuni();
            user.Show();
            this.Hide();
        }

        private void cross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void JoinACC_Click(object sender, EventArgs e)
        {
            Session.University = "BRAC";
            Session.Club = "ROBU";
            Registration regForm = new Registration();
            regForm.Show();
            this.Hide();
        }

        private void JoinABC_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Club is currently inactive.");
        }

        private void JoinADC_Click(object sender, EventArgs e)
        {
            Session.University = "BRAC";
            Session.Club = "CC";
            Registration regForm = new Registration();
            regForm.Show();
            this.Hide();
        }

        private void JoinARND_Click(object sender, EventArgs e)
        {
            Session.University = "BRAC";
            Session.Club = "AC";
            Registration regForm = new Registration();
            regForm.Show();
            this.Hide();
        }

        private void ViewARND_Click(object sender, EventArgs e)
        {
            Event_BUAC_User event_BUAC_User = new Event_BUAC_User();
            event_BUAC_User.Show();
            this.Hide();
        }

        private void Event_ROBU_Click(object sender, EventArgs e)
        {
            Event_ROBU_User event_ROBU_User = new Event_ROBU_User();
            event_ROBU_User.Show();
            this.Hide();
        }

        private void EventBUBC_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Club is currently inactive, it has nothing to show");
        }

        private void EventBUCC_Click(object sender, EventArgs e)
        {
            Event_BUCC_User event_BUCC_User = new Event_BUCC_User();
            event_BUCC_User.Show();
            this.Hide();
        }
    }
}
