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
            Registration Aiubreg = new Registration();
            Aiubreg.Show();
            this.Hide();
        }

        private void JoinABC_Click(object sender, EventArgs e)
        {
            Registration Aiubreg = new Registration();
            Aiubreg.Show();
            this.Hide();
        }

        private void JoinADC_Click(object sender, EventArgs e)
        {
            Registration Aiubreg = new Registration();
            Aiubreg.Show();
            this.Hide();
        }

        private void JoinARND_Click(object sender, EventArgs e)
        {
            Registration Aiubreg = new Registration();
            Aiubreg.Show();
            this.Hide();
        }
    }
}
