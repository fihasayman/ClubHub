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
    public partial class Event_BUCC : Form
    {
        public Event_BUCC()
        {
            InitializeComponent();
        }

        private void Goback_Click(object sender, EventArgs e)
        {
            BRACclub brac = new BRACclub();
            brac.Show();
            this.Hide();
        }

        private void cross_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
