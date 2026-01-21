using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Final_Project
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Goback_Click(object sender, EventArgs e)
        {
            Profile pro = new Profile();
            pro.Show();
            this.Hide();
        }

        private void Admin_Login_Click(object sender, EventArgs e)
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



            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-IILFUCP\SQLEXPRESS;Initial Catalog=UniversityClubDB;Integrated Security=True;Encrypt=False");

            try
            {
                con.Open();

                string query = @" SELECT Role FROM Users WHERE Email = @email AND Password = @password AND IsActive = 1";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            string role = dr["Role"].ToString();

                            if (role == "Admin")
                            {
                                MessageBox.Show("Admin Login Succesfull!");
                                new Admin_Choose_Uni().Show();
                                this.Hide();
                            }

                            else
                            {
                                MessageBox.Show(
                                    "This login is restricted to Admin only.",
                                    "Access denied",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning
                                );
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid email or password.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to database: " + ex.Message);
            }
        }
    }
}
