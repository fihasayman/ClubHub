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
    public partial class Edit3_Event : Form
    {
        public Edit3_Event()
        {
            InitializeComponent();
        }

        private void cross_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Changes Saved!");
            this.Close();
        }
    }
}
