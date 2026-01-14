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
    public partial class President_ACC_Event : Form
    {
        public President_ACC_Event()
        {
            InitializeComponent();
        }

        private void cross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Applicant_Click(object sender, EventArgs e)
        {
            President_ACC_App applicant = new President_ACC_App();
            applicant.Show();
            this.Hide();
        }

        private void Member_Click(object sender, EventArgs e)
        {
            President_ACC_Mem member = new President_ACC_Mem();
            member.Show();
            this.Hide();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            Edit_Event editEvent = new Edit_Event();
            editEvent.ShowDialog();
            //panel3.BackColor = Color.FromArgb(120, 0, 0, 0);

        }

        private void Add_Event_Click(object sender, EventArgs e)
        {
            Add_Event_ACC add_Event_ACC = new Add_Event_ACC();
            add_Event_ACC.ShowDialog();
        }

        private void Edit2_Click(object sender, EventArgs e)
        {
            Edit2_Event edit2 = new Edit2_Event();
            edit2.ShowDialog();
        }

        private void Edit3_Click(object sender, EventArgs e)
        {
            Edit3_Event edit3 = new Edit3_Event();
            edit3.ShowDialog();
        }

        private void Goback_Click(object sender, EventArgs e)
        {
            AIUBclub clubPanel = new AIUBclub();
            clubPanel.Show();
            this.Hide();
        }
    }
}
