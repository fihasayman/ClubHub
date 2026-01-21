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
    public partial class Uni : Form
    {
        public Uni()
        {
            InitializeComponent();
        }

        private void AIUB_Click(object sender, EventArgs e)
        { 
            Session.University = "AIUB";

            AIUBclub clubPanel = new AIUBclub();
            clubPanel.Show();
            this.Hide();
        }

        private void BRAC_Click(object sender, EventArgs e)
        {
            Session.University = "BRAC";
            BRACclub brac = new BRACclub();
            brac.Show();
            this.Hide();
        }

        private void IUB_Click(object sender, EventArgs e)
        {
            Session.University = "IUB";
            IUBClub iub = new IUBClub();
            iub.Show();
            this.Hide();
        }

        private void NSU_Click(object sender, EventArgs e)
        {
            Session.University = "NSU";
            NSUclub nsu = new NSUclub();
            nsu.Show();
            this.Hide();
        }

        private void Goback_Click(object sender, EventArgs e)
        {
            Profile pro = new Profile();
            pro.Show();
            this.Hide();
        }

        private void cross_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Uni_Load(object sender, EventArgs e)
        {

        }
    }
}
