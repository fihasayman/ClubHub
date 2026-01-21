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
    public partial class IUBClub : Form
    {
        public IUBClub()
        {
            InitializeComponent();
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

        private void LoginIMA_Click(object sender, EventArgs e) => Login_Club("IUB", "IMA");
        private void LoginIAA_Click(object sender, EventArgs e) => Login_Club("IUB", "IAA");
        private void LoginIHRS_Click(object sender, EventArgs e) => Login_Club("IUB", "IHRS");
        private void LoginIPC_Click(object sender, EventArgs e) => Login_Club("IUB", "IPC");

        private void IUBClub_Load(object sender, EventArgs e)
        {

        }

        private void EventIAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Club is currently inactive, it has nothing to show");
        }

        private void EventIPC_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Club is currently inactive, it has nothing to show");
        }

        private void EventIMA_Click(object sender, EventArgs e)
        {
            Event_IMA iubIMAEvent = new Event_IMA();
            iubIMAEvent.Show();
            this.Hide();
        }

        private void EventIHRS_Click(object sender, EventArgs e)
        {
            Event_IHRS iubIHRS_Event = new Event_IHRS();
            iubIHRS_Event.Show();
            this.Hide();
        }
    }
}
