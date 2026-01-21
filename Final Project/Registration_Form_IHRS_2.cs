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
    public partial class Registration_Form_IHRS_2 : Form
    {
        public Registration_Form_IHRS_2()
        {
            InitializeComponent();
        }

        private void cross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegistrationIHRS2_Click(object sender, EventArgs e)
        {
            // Get data from TextBoxes
            string firstName = Event_title2.Text.Trim();
            string lastName = textBox4.Text.Trim();
            string email = textBox1.Text.Trim();
            string phone = textBox2.Text.Trim();
            string studentID = textBox3.Text.Trim();
            string semester = textBox5.Text.Trim();
            string department = textBox6.Text.Trim();

            string clubMember = "";
            if (radioButton2.Checked)
            {
                clubMember = "yes";
            }
            else if (radioButton1.Checked)
            {
                clubMember = "no";
            }

            if (string.IsNullOrWhiteSpace(firstName) ||
                 string.IsNullOrWhiteSpace(lastName) ||
                 string.IsNullOrWhiteSpace(email) ||
                 string.IsNullOrWhiteSpace(phone) ||
                 string.IsNullOrWhiteSpace(studentID) ||
                 string.IsNullOrWhiteSpace(semester) ||
                 string.IsNullOrWhiteSpace(department) ||
                 string.IsNullOrWhiteSpace(clubMember))
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

            // Connection String
            string connectionString =
                @"Data Source=DESKTOP-IILFUCP\SQLEXPRESS;Initial Catalog=UniversityClubDB;Integrated Security=True;Encrypt=False";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string query = @"
                        INSERT INTO IHRS_Event2_Registration
                        (FirstName, LastName, Email, Phone, StudentID,semester, Department, ClubMember)
                        VALUES
                        (@fname, @lname, @email, @phone, @studentid, @semester,@dept,@clubmember)";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@fname", firstName);
                    cmd.Parameters.AddWithValue("@lname", lastName);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@studentid", studentID);
                    cmd.Parameters.AddWithValue("@semester", semester);
                    cmd.Parameters.AddWithValue("@dept", department);
                    cmd.Parameters.AddWithValue("@clubmember", clubMember);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Event Registration is Successful!");
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
