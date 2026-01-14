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
            this.Show();
        }

        private void LoginACC_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void LoginABC_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This club is currently inactive.");
        }

        private void LoginADC_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void LoginARND_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
