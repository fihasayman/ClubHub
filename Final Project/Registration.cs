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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            string Firstname = textBox4.Text;
            if (Firstname == "")
            {
                MessageBox.Show("First Name is required");
                textBox4.Focus();
                return;
            }

            string Lastname = textBox3.Text;
            if (Lastname == "")
            {
                MessageBox.Show("Last Name is required");
                textBox3.Focus();
                return;
            }



            string email = textBox1.Text;
            if (email == "")
            {
                MessageBox.Show("Email is required");
                textBox1.Focus();
                return;
            }
            int atCount = email.Split('@').Length - 1;
            if (atCount != 1 || !email.Contains(".") || email.Contains(".."))
            {
                MessageBox.Show("Enter a valid email");
                textBox1.Focus();
                return;
            }


            string password = textBox7.Text;
            string confirmPassword = textBox8.Text;
            if (password == "")
            {
                MessageBox.Show("Password is required");
                textBox7.Focus();
                return;
            }
            if (confirmPassword == "")
            {
                MessageBox.Show("Confirm Password is required");
                textBox8.Focus();
                return;
            }
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match");
                textBox7.Focus();
                return;
            }
            if (password.Length < 4)
            {
                MessageBox.Show("Password must be at least 4 characters");
                textBox7.Focus();
                textBox8.Focus();
                return;
            }


            string phone = textBox2.Text;
            if (phone == "")
            {
                MessageBox.Show("Phone number is required");
                textBox2.Focus();
                return;
            }
            foreach (char c in phone)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("Phone number can only contain digits");
                    textBox2.Focus();
                    return;
                }
            }
            if (phone.Length != 11)
            {
                MessageBox.Show("Phone number must be 11 digits");
                textBox2.Focus();
                return;
            }

            string dept = textBox5.Text;
            if (dept == "")
            {
                MessageBox.Show("Department is required");
                textBox5.Focus();
                return;
            }


            string studentID = textBox6.Text;
            if (studentID == "")
            {
                MessageBox.Show("Student ID is required");
                textBox6.Focus();
                return;
            }
            string gender = "";
            if (radioButton1.Checked)
            { gender = "Male"; }
            else if (radioButton2.Checked)
            { gender = "Female"; }
            else if (radioButton3.Checked)
            {
                gender = "Other";
            }
            if (gender == "")
            {
                MessageBox.Show("Please Select a Gender!");
                return;
            }





            /*string firstName = textBox4.Text.Trim();
            string lastName = textBox3.Text.Trim();
            string email = textBox1.Text.Trim();
            string phone = textBox2.Text.Trim();
            string studentID = textBox6.Text.Trim();
            string department = textBox5.Text.Trim();
            string password = textBox7.Text.Trim();

            string gender = "";

            if (radioButton1.Checked)
                gender = "Male";
            else if (radioButton2.Checked)
                gender = "Female";
            else if (radioButton3.Checked)
                gender = "Other";

            if (firstName == "" || lastName == "" || email == "" ||
                phone == "" || studentID == "" || department == "" ||
                password == "" || gender == "")
            {
                MessageBox.Show("All fields are required.");
                return;
            }*/

            if (Session.University == null || Session.Club == null)
            {
                MessageBox.Show("University or Club not selected. Please select again.");
                return;
            }


            string university = Session.University.ToString().Trim().ToUpper();
            string club = Session.Club.ToString().Trim().ToUpper();

            MessageBox.Show("University: " + university + " | Club: " + club);

            string tableName = "";


            if (university == "AIUB")
            {
                if (club == "ACC") tableName = "ACC_Applicants";
                else if (club == "ABC") tableName = "ABC_Applicants";
                else if (club == "ADC") tableName = "ADC_Applicants";
            }
            else if (university == "BRAC")
            {
                if (club == "AC") tableName = "BracAC_Applicants";
                else if (club == "CC") tableName = "BracCC_Applicants";
                else if (club == "ROBU") tableName = "BracRobu_Applicants";
            }
            else if (university == "NSU")
            {
                if (club == "CEC") tableName = "NSUCEC_Applicants";
                else if (club == "PHSC") tableName = "NSUPHSC_Applicants";
                else if (club == "YES") tableName = "NSUYES_Applicants";
            }
            else if (university == "IUB")
            {
                if (club == "HRS") tableName = "IUBHRS_Applicants";
                else if (club == "MA") tableName = "IUBMA_Applicants";
            }


            if (string.IsNullOrEmpty(tableName))
            {
                MessageBox.Show("Invalid Club Selection. Mapping not found.");
                return;
            }

            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-IILFUCP\SQLEXPRESS;Initial Catalog=UniversityClubDB;Integrated Security=True;Encrypt=False"))
            {
                try
                {
                    con.Open();

                    string query = $@"
INSERT INTO [{tableName}]
(FirstName, LastName, Email, Phone, StudentID, Department, Password, Gender, Status, IsActive)
VALUES
(@fname, @lname, @email, @phone, @studentid, @dept, @password, @gender, 'Pending', 1)";


                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@fname", Firstname);
                    cmd.Parameters.AddWithValue("@lname", Lastname);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@studentid", studentID);
                    cmd.Parameters.AddWithValue("@dept", dept);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@gender", gender);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registration Successful!");
                    MessageBox.Show("Wait for the call from the club president via email.");

                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                }
            }
        }



        private void ClearFields()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;

        }

        private void Goback_Click(object sender, EventArgs e)
        {
            Form previousPage = Session.University switch
            {
                "AIUB" => new AIUBuser(),
                "BRAC" => new BRACuser(),
                "IUB" => new IUBuser(),
                "NSU" => new NSUuser(),
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
