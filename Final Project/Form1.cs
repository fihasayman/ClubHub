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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void email_Click(object sender, EventArgs e)
        {

        }

        private void pass_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            this.Hide();
        }

        private void Login_President(object sender, EventArgs e)
        {
            /*President_ACC_Mem member = new President_ACC_Mem();
            member.Show();
            this.Hide();*/
            Session.Role = "President";
            Dashboard();
        }

        private void Dashboard()
        {
            string key = $"{Session.University}_{Session.Club}_{Session.Role}";

            Form dashboard = key switch
            {
                "AIUB_ACC_President" => new President_ACC_Mem(),
                "AIUB_ACC_Member" => new AIUB_ACC_Member(),

                "AIUB_ABC_President" => new President_ABC_Mem(),
                "AIUB_ABC_Member" => new AIUB_ABC_Member(),

                "AIUB_ADC_President" => new President_ADC_Mem(),
                "AIUB_ADC_Member" => new AIUB_ADC_Member(),


                _ => null
            };

            if (dashboard == null)
            {
                MessageBox.Show("This Club is currently inactive.");
                return;
            }

            dashboard.Show();
            this.Hide();
        }


        private void Goback_Click(object sender, EventArgs e)
        {
            AIUBclub clubPanel = new AIUBclub();
            clubPanel.Show();
            this.Hide(); ;
        }
    }
}
