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
    public partial class BRACclub : Form
    {
        public BRACclub()
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

        private void LoginROBU_Click(object sender, EventArgs e) => Login_Club("BRAC", "ROBU");
        private void LoginBUCC_Click(object sender, EventArgs e) => Login_Club("BRAC", "BUCC");
        private void LoginBUAC_Click(object sender, EventArgs e) => Login_Club("BRAC", "BUAC");
        private void LoginBUBC_Click(object sender, EventArgs e) => Login_Club("BRAC", "BUBC");

        private void Event_ROBU_Click(object sender, EventArgs e)
        {
            Event_ROBU eventROBU = new Event_ROBU();
            eventROBU.Show();
            this.Hide();
        }

        private void EventBUBC_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Club is currently inactive, it has nothing to show");
        }

        private void Event_BUCC_Click(object sender, EventArgs e)
        {
            Event_BUCC eventBUCC = new Event_BUCC();
            eventBUCC.Show();
            this.Hide();
        }

        private void Event_BUAC_Click(object sender, EventArgs e)
        {
            Event_BUAC eventBUAC = new Event_BUAC();
            eventBUAC.Show();
            this.Hide();
        }

        private void BRACclub_Load(object sender, EventArgs e)
        {

        }
    }
}
