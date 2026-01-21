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
    public partial class IUBuser : Form
    {
        public IUBuser()
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
            Session.University = "IUB";
            Session.Club = "MA";
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
            Session.University = "IUB";
            Session.Club = "HRS";
            Registration regForm = new Registration();
            regForm.Show();
            this.Hide();
        }

        private void JoinARND_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Club is currently inactive.");
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
            Event_IMA_User event_IMA_User = new Event_IMA_User();
            event_IMA_User.Show();
            this.Hide();
        }

        private void EventIHRS_Click(object sender, EventArgs e)
        {
            Event_IHRS_User event_IHRS_User = new Event_IHRS_User();
            event_IHRS_User.Show();
            this.Hide();
        }
    }
}
