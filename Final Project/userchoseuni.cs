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
    public partial class userchoseuni : Form
    {
        public userchoseuni()
        {
            InitializeComponent();
        }

        private void AIUB_Click(object sender, EventArgs e)
        {
            Session.University = "AIUB";
            AIUBuser Aiubuser = new AIUBuser();
            Aiubuser.Show();
            this.Hide();
        }

        private void cross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IUB_Click(object sender, EventArgs e)
        {
            Session.University = "IUB";
            IUBuser iubuser = new IUBuser();
            iubuser.Show();
            this.Hide();
        }

        private void BRAC_Click(object sender, EventArgs e)
        {
            Session.University = "BRAC";
            BRACuser bracuser = new BRACuser();
            bracuser.Show();
            this.Hide();
        }

        private void NSU_Click(object sender, EventArgs e)
        {
            Session.University = "NSU";
            NSUuser nsuuser = new NSUuser();
            nsuuser.Show();
            this.Hide();
        }

        private void Goback_Click(object sender, EventArgs e)
        {
            Profile pro = new Profile();
            pro.Show();
            this.Hide();
        }
    }
}
