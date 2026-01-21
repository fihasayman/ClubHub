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
    public partial class Event_NCEC : Form
    {
        public Event_NCEC()
        {
            InitializeComponent();
        }

        private void Goback_Click(object sender, EventArgs e)
        {
            NSUclub nSUclub = new NSUclub();
            nSUclub.Show();
            this.Hide();
        }

        private void cross_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
