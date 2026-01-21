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
    public partial class AIUBuser : Form
    {
        public AIUBuser()
        {
            InitializeComponent();
        }

        private void cross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void JoinACC_Click(object sender, EventArgs e)
        {
            Session.University = "AIUB";
            Session.Club = "ACC";
            Registration regForm = new Registration();
            regForm.Show();
            this.Hide();
        }

        private void JoinABC_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Club is currently inactive, it has nothing to show");
        }

        private void JoinADC_Click(object sender, EventArgs e)
        {
            Session.University = "AIUB";
            Session.Club = "ADC";
            Registration regForm = new Registration();
            regForm.Show();
            this.Hide();
        }

        private void JoinARND_Click(object sender, EventArgs e)
        {
            Session.University = "AIUB";
            Session.Club = "ABC";
            Registration regForm = new Registration();
            regForm.Show();
            this.Hide();
            
        }

        private void Goback_Click(object sender, EventArgs e)
        {
            userchoseuni user = new userchoseuni();
            user.Show();
            this.Hide();
        }

        private void ViewARND_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Club is currently inactive, it has nothing to show");
        }

        private void ViewACC_Click(object sender, EventArgs e)
        {
            Event_ACC_User event_ACC_User = new Event_ACC_User();
            event_ACC_User.Show();
            this.Hide();

        }

        private void EventABC_Click(object sender, EventArgs e)
        {
            Event_ABC_User event_ABC_User = new Event_ABC_User();
            event_ABC_User.Show();
            this.Hide();
        }

        private void EventADC_Click(object sender, EventArgs e)
        {
            Event_ADC_User event_ADC_User = new Event_ADC_User();
            event_ADC_User.Show();
            this.Hide();
        }
    }
}
