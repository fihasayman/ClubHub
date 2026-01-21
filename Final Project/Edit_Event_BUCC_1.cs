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
    public partial class Edit_Event_BUCC_1 : Form
    {
        public Edit_Event_BUCC_1()
        {
            InitializeComponent();
        }

        private void cross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Changes Saved!");
            this.Close();
        }
    }
}
