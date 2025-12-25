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
    public partial class Add_Event_ADC : Form
    {
        public Add_Event_ADC()
        {
            InitializeComponent();
        }

        private void SaveEvent_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Event Added Successfully!");
            this.Close();
        }

        private void cross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
