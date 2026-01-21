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
    public partial class AIUBclub : Form
    {
        public AIUBclub()
        {
            InitializeComponent();
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

        private void LoginACC_Click(object sender, EventArgs e) => Login_Club("AIUB", "ACC");
        private void LoginABC_Click(object sender, EventArgs e) => Login_Club("AIUB", "ABC");
        private void LoginADC_Click(object sender, EventArgs e) => Login_Club("AIUB", "ADC");
        private void LoginARND_Click(object sender, EventArgs e) => Login_Club("AIUB", "ARND");

        private void JoinACC_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            this.Hide();
        }

        private void JoinABC_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            this.Hide();
        }

        private void JoinADC_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            this.Hide();
        }

        private void JoinARND_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            this.Hide();
        }

        private void ViewACC_Click(object sender, EventArgs e)
        {
            EventACC EACC = new EventACC();
            EACC.Show();
            this.Hide();
        }

        private void ViewADC_Click(object sender, EventArgs e)
        {
            EventADC EADC = new EventADC();
            EADC.Show();
            this.Hide();
        }

        private void Goback_Click(object sender, EventArgs e)
        {
            Uni choseuni = new Uni();
            choseuni.Show();
            this.Hide();
        }

        private void ViewABC_Click(object sender, EventArgs e)
        {
            EventABC EABC = new EventABC();
            EABC.Show();
            this.Hide();
        }

        private void ViewARND_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Club is currently inactive, it has nothing to show");
        }

        private void AIUBclub_Load(object sender, EventArgs e)
        {

        }
    }
}
