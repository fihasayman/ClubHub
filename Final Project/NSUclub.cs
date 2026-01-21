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
    public partial class NSUclub : Form
    {
        public NSUclub()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NSUclub_Load(object sender, EventArgs e)
        {

        }

        private void Goback_Click(object sender, EventArgs e)
        {
            Uni choseuni = new Uni();
            choseuni.Show();
            this.Hide();
        }

        private void cross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Club(string university, string club)
        {
            Session.University = university;
            Session.Club = club;

            if (Session.Role == "President")
            {
                Login presidentLogin = new Login();
                presidentLogin.Show();
            }
            else if (Session.Role == "Member")
            {
                FormMember memberLogin = new FormMember();
                memberLogin.Show();
            }

            this.Hide();
        }

        private void LoginYES_Click(object sender, EventArgs e) => Login_Club("NSU", "YES");
        private void LoginPHSC_Click(object sender, EventArgs e) => Login_Club("NSU", "PHSC");
        private void LoginCEC_Click(object sender, EventArgs e) => Login_Club("NSU", "CEC");
        private void LoginAPC_Click(object sender, EventArgs e) => Login_Club("NSU", "APC");

        private void EventAPC_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Club is currently inactive, it has nothing to show");
        }

        private void EventYES_Click(object sender, EventArgs e)
        {
            Event_NYES Event_NYES = new Event_NYES();
            Event_NYES.Show();
            this.Hide();
        }

        private void EventPHSC_Click(object sender, EventArgs e)
        {
            Event_PHSC Event_PHSC = new Event_PHSC();
            Event_PHSC.Show();
            this.Hide();
        }

        private void EventCEC_Click(object sender, EventArgs e)
        {
            Event_NCEC Event_NCEC = new Event_NCEC();
            Event_NCEC.Show();
            this.Hide();
        }
    }
}
