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
    public partial class Volunteer_Form_ROBU_2 : Form
    {
        public Volunteer_Form_ROBU_2()
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

        private void ApplyROBU2_Click(object sender, EventArgs e)
        {
            // Get data from TextBoxes
            string firstName = Event_title2.Text.Trim();
            string lastName = textBox4.Text.Trim();
            string email = textBox1.Text.Trim();
            string phone = textBox2.Text.Trim();
            string experienceSkills = textBox3.Text.Trim();

            string availability = "";
            if (checkBox1.Checked)
            {
                availability = "sunday";
            }
            else if (checkBox2.Checked)
            {
                availability = "monday";
            }
            else if (checkBox3.Checked)
            {
                availability = "tuesday";
            }
            else if (checkBox5.Checked)
            {
                availability = "wednesday";
            }
            else if (checkBox7.Checked)
            {
                availability = "thrusday";
            }
            else if (checkBox4.Checked)
            {
                availability = "I agree to the terms and conditions of volunteering and understand my responsibilities as a volunteer for this event. *";
            }


            if (string.IsNullOrWhiteSpace(firstName) ||
                 string.IsNullOrWhiteSpace(lastName) ||
                 string.IsNullOrWhiteSpace(email) ||
                 string.IsNullOrWhiteSpace(phone) ||
                 string.IsNullOrWhiteSpace(experienceSkills)
                )
            {
                MessageBox.Show("All fields are required.");
                return;
            }
            // Optional: Email format check
            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Enter a valid email.");
                return;
            }

            // Optional: Numeric check for phone
            if (!long.TryParse(phone, out _))
            {
                MessageBox.Show("Phone number must be numeric.");
                return;
            }


            string connectionString =
            @"Data Source=DESKTOP-IILFUCP\SQLEXPRESS;Initial Catalog=UniversityClubDB;Integrated Security=True;Encrypt=False";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string query = @"
            INSERT INTO ROBU_Event2_Volunteer
            (FirstName, LastName, Email, Phone, ExperienceSkills, Availability)
            VALUES
            (@fname, @lname, @email, @phone, @skills, @availability)";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@fname", firstName);
                    cmd.Parameters.AddWithValue("@lname", lastName);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@skills", experienceSkills);
                    cmd.Parameters.AddWithValue("@availability", availability);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Volunteer Registration Successful!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                }
            }
        }
    }
}
