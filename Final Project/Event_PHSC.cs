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
    public partial class Event_PHSC : Form
    {
        public Event_PHSC()
        {
            InitializeComponent();
        }

        private void Goback_Click(object sender, EventArgs e)
        {
            NSUclub nsuclub = new NSUclub();
            nsuclub.Show();
            this.Hide();
        }

        private void cross_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
