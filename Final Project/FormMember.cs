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
                //AIUB
                "AIUB_ACC" => new AIUB_ACC_Member(),
                "AIUB_ABC" => new AIUB_ABC_Member(),
                "AIUB_ADC" => new AIUB_ADC_Member(),

                //BRAC
                "BRAC_ROBU" => new BRAC_ROBU_Member(),
                "BRAC_BUCC" => new BRAC_BUCC_Member(),
                "BRAC_BUAC" => new BRAC_BUAC_Member(),

                //IUB
                "IUB_IMA" => new IUB_IMA_Member(),
                "IUB_IHRS" => new IUB_IHRS_Member(),

                //NSU
                "NSU_YES" => new NSU_YES_Member(),
                "NSU_PHSC" => new NSU_PHSC_Member(),
                "NSU_CEC" => new NSU_CEC_Member(),


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
           string email = textBox1.Text.Trim();
            string password = textBox2.Text;

            if (email == "")
            {
                MessageBox.Show("Email is required");
                textBox1.Focus();
                return;
            }

            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Enter a valid email");
                textBox1.Focus();
                return;
            }

            if (password == "")
            {
                MessageBox.Show("Password is required");
                textBox2.Focus();
                return;
            }




            string university = Session.University;
            string club = Session.Club;
            string tableName = "";

            // Set table name AIUB

            if (university == "AIUB" && club == "ACC")
            {
                tableName = "ACC_Member";
            }
            else if (university == "AIUB" && club == "ABC")
            {
                tableName = "ABC_Member";
            }
            else if (university == "AIUB" && club == "ADC")
            {
                tableName = "ADC_Member";
            }


            // Set table name BRAC
            else if (university == "BRAC" && club == "ROBU")
            {
                tableName = "BracRobu_Member";
            }
            else if (university == "BRAC" && club == "BUCC")
            {
                tableName = "BUCC_Member";
            }
            else if (university == "BRAC" && club == "BUAC")
            {
                tableName = "BUAC_Member";
            }


            // Set table name IUB
            else if (university == "IUB" && club == "IMA")
            {
                tableName = "IUBMA_Member";
            }
            else if (university == "IUB" && club == "IHRS")
            {
                tableName = "IUBHRS_Member";
            }

            // Set table name NSU
            else if (university == "NSU" && club == "YES")
            {
                tableName = "NSUYES_Member";
            }
            else if (university == "NSU" && club == "PHSC")
            {
                tableName = "NSUPHSCMember";
            }
            else if (university == "NSU" && club == "CEC")
            {
                tableName = "NSUCEC_Member";
            }
            else
            {
                MessageBox.Show("Invalid University or Club Selection.");
                return;
            }


            // Database connection
            using (SqlConnection con = new SqlConnection(
                @"Data Source=DESKTOP-IILFUCP\SQLEXPRESS;Initial Catalog=UniversityClubDB;Integrated Security=True;Encrypt=False"))
            {
                try
                {
                    con.Open();
                    
                    string query = $@"SELECT Email FROM [{tableName}] 
                          WHERE Email = @email AND Password = @password"; // make sure column exists

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@password", password); // Hash in production

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                MessageBox.Show("Login Successful!");
                                Session.Role = "Member";
                                OpenDashboard();

                            }
                            else
                            {
                                MessageBox.Show("Invalid Email or Password OR Wrong Club Selected.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                }
            }


           
        }

        private void Goback_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
