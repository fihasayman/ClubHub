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
            AIUBclub club = new AIUBclub();
            club.Show();
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
