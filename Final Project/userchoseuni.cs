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
            AIUBuser Aiubuser = new AIUBuser();
            Aiubuser.Show();
            this.Hide();
        }

        private void cross_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void IUB_Click(object sender, EventArgs e)
        {
            IUBuser iubuser = new IUBuser();
            iubuser.Show();
            this.Hide();
        }

        private void BRAC_Click(object sender, EventArgs e)
        {
            BRACuser bracuser = new BRACuser();
            bracuser.Show();
            this.Hide();
        }

        private void NSU_Click(object sender, EventArgs e)
        {
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
