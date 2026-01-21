using Microsoft.Data.SqlClient;
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


            string email = textBox1.Text.Trim();
            string password = textBox2.Text;

            if (email == "")
            {
                MessageBox.Show("Email is required");
                return;
            }

            if (password == "")
            {
                MessageBox.Show("Password is required");
                return;
            }

            string university = Session.University.Trim().ToUpper();
            string club = Session.Club.Trim().ToUpper();

            string tableName = "";

            if (university == "AIUB")
            {
                if (club == "ACC") tableName = "ACC_President";
                else if (club == "ABC") tableName = "ABC_President";
                else if (club == "ADC") tableName = "ADC_President";
            }
            else if (university == "BRAC")
            {
                if (club == "BUAC") tableName = "BracAC_President";
                else if (club == "BUCC") tableName = "BracCC_President";
                else if (club == "ROBU") tableName = "BracRobu_President";
            }
            else if (university == "NSU")
            {
                if (club == "CEC") tableName = "NSUCEC_President";
                else if (club == "PHSC") tableName = "NSUPHSC_President";
                else if (club == "YES") tableName = "NSUYES_President";
            }
            else if (university == "IUB")
            {
                if (club == "IHRS") tableName = "IUBHRS_President";
                else if (club == "IMA") tableName = "IUBMA_President";
            }
            else
            {
                MessageBox.Show("Invalid Club Selection.");
                return;
            }

            if (string.IsNullOrEmpty(tableName))
            {
                MessageBox.Show("Club table not found for the selected university.");
                return;
            }

            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-IILFUCP\SQLEXPRESS;Initial Catalog=UniversityClubDB;Integrated Security=True;Encrypt=False"))
            {
                try
                {
                    con.Open();

                    string query = $@"
SELECT Email
FROM [{tableName}]
WHERE Email = @email AND Password = @password";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        MessageBox.Show("Login Successful!");
                        Session.Role = "President";
                        OpenDashboard();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Email or Password OR Wrong Club Selected.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                }
            }
        }


        private void OpenDashboard()
        {
            string key = $"{Session.University}_{Session.Club}";

            Form presidentForm = key switch
            {
                //AIUB
                "AIUB_ACC" => new President_ACC_Mem(),
                "AIUB_ABC" => new President_ABC_Mem(),
                "AIUB_ADC" => new President_ADC_Mem(),

                //BRAC
                "BRAC_ROBU" => new President_ROBU_Mem(),
                "BRAC_BUCC" => new President_BUCC_Mem(),
                "BRAC_BUAC" => new President_BUAC_Mem(),

                //IUB
                "IUB_IMA" => new President_IMA_Mem(),
                "IUB_IHRS" => new President_IHRS_Mem(),

                //NSU
                "NSU_YES" => new President_YES_Mem(),
                "NSU_PHSC" => new President_PHSC_Mem(),
                "NSU_CEC" => new President_CEC_Mem(),


                _ => null
            };

            if (presidentForm == null)
            {
                MessageBox.Show("President panel not found for this club.");
                return;
            }

            presidentForm.Show();
            this.Hide();
        }

        private void PresidentLogin_Click(object sender, EventArgs e)
        {
            OpenDashboard();
        }


        private void Goback_Click(object sender, EventArgs e)
        {
            {
                Form previousPage = Session.University switch
                {
                    "AIUB" => new AIUBclub(),
                    "BRAC" => new BRACclub(),
                    "IUB" => new IUBClub(),
                    "NSU" => new NSUclub(),
                    _ => null
                };

                if (previousPage == null)
                {
                    MessageBox.Show("Previous page not found.");
                    return;
                }

                previousPage.Show();
                this.Hide();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
