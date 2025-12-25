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
    public partial class FormMember : Form
    {
        public FormMember()
        {
            InitializeComponent();
        }

        private void FormMember_Load(object sender, EventArgs e)
        {

        }

        private void OpenDashboard()
        {
            string key = $"{Session.University}_{Session.Club}";

            Form memberForm = key switch
            {
                "AIUB_ACC" => new AIUB_ACC_Member(),
                "AIUB_ABC" => new AIUB_ABC_Member(),
                "AIUB_ADC" => new AIUB_ADC_Member(),

                _ => null
            };

            if (memberForm == null)
            {
                MessageBox.Show("Member panel not found for this club.");
                return;
            }

            memberForm.Show();
            this.Hide();
        }

        private void MemberLogin_Click(object sender, EventArgs e)
        {
            OpenDashboard();
        }

        private void Goback_Click(object sender, EventArgs e)
        {
            AIUBclub clubPanel = new AIUBclub();
            clubPanel.Show();
            this.Hide();
        }
    }
}
