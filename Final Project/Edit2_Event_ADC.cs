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
    public partial class Edit2_Event_ADC : Form
    {
        public Edit2_Event_ADC()
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

        private void SaveADC2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Changes Saved!");
            this.Close();
        }

        private void S_time_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
