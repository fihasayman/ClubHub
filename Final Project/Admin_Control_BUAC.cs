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
    public partial class Admin_Control_BUAC : Form
    {
        public Admin_Control_BUAC()
        {
            InitializeComponent();
        }

        private void cross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Profile adminProfile = new Profile();
            adminProfile.Show();
            this.Hide();
        }

        private void Goback_Click(object sender, EventArgs e)
        {
            Admin_Choose_Uni adminChooseUni = new Admin_Choose_Uni();
            adminChooseUni.Show();
            this.Hide();
        }

        private void BUBC_Pre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BRAC University Business Club President access is not available at the moment.");
        }

        private void BUCC_Pre_Click(object sender, EventArgs e)
        {
            Admin_Control_BUCC BUCCAdmin = new Admin_Control_BUCC();
            BUCCAdmin.Show();
            this.Hide();
        }

        private void ROBU_Pre_Click(object sender, EventArgs e)
        {
            Admin_Control_BRAC BUCCAdmin = new Admin_Control_BRAC();
            BUCCAdmin.Show();
            this.Hide();
        }

        private void Load_Pre_ACC_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-IILFUCP\SQLEXPRESS;Initial Catalog=UniversityClubDB;Integrated Security=True;Encrypt=False"))
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT ID, FirstName, LastName, Email, Phone,Password, Gender, StudentID, Department, Age FROM BracAC_President", con);

                DataTable dt = new DataTable();
                da.Fill(dt);
                GridViewMem.DataSource = dt;

                if (GridViewMem.Columns["ID"] != null)
                    GridViewMem.Columns["ID"].Visible = false;
                //if (GridViewMem.Columns["Password"] != null)
                    //GridViewMem.Columns["Password"].Visible = false;
            }
        }

        private void Update_Mem_Click(object sender, EventArgs e)
        {
            if (GridViewMem.CurrentRow == null)
            {
                MessageBox.Show("Select a row first", "Select Row", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRowView rowView = (DataRowView)GridViewMem.CurrentRow.DataBoundItem;
            DataRow row = rowView.Row;

            int id = 0;
            if (row["ID"] != DBNull.Value)
            {
                int.TryParse(row["ID"].ToString(), out id);
            }

            string firstName = row["FirstName"].ToString().Trim();
            string lastName = row["LastName"].ToString().Trim();
            string email = row["Email"].ToString().Trim();
            string phone = row["Phone"].ToString().Trim();
            string gender = row["Gender"].ToString().Trim();
            string password = row["Password"].ToString().Trim();
            string studentID = row["StudentID"].ToString().Trim();
            string department = row["Department"].ToString().Trim();

            int age = 0;
            if (row["Age"] != DBNull.Value && !string.IsNullOrWhiteSpace(row["Age"].ToString()))
            {
                age = Convert.ToInt32(row["Age"]);
            }

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phone) ||
                string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(studentID) || string.IsNullOrEmpty(department) || age == 0)
            {
                MessageBox.Show("All fields are required! Please fill in every field before saving.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-IILFUCP\SQLEXPRESS;Initial Catalog=UniversityClubDB;Integrated Security=True;Encrypt=False"))
            {
                con.Open();

                if (id == 0)
                {
                    string insertQuery = @"INSERT INTO BracAC_President
(FirstName, LastName, Email, Phone, Gender, Password, StudentID, Department, Age)
VALUES (@FirstName,@LastName,@Email,@Phone,@Gender,@Password,@StudentID,@Department,@Age);
SELECT SCOPE_IDENTITY()";

                    SqlCommand cmd = new SqlCommand(insertQuery, con);
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@StudentID", studentID);
                    cmd.Parameters.AddWithValue("@Department", department);
                    cmd.Parameters.AddWithValue("@Age", age);

                    int newId = Convert.ToInt32(cmd.ExecuteScalar());
                    row["ID"] = newId;
                    MessageBox.Show("New president added successfully.");
                }
                else
                {
                    string updateQuery = @"UPDATE BracAC_President SET 
FirstName=@FirstName, LastName=@LastName, Email=@Email, Phone=@Phone, Gender=@Gender,
Password=@Password, StudentID=@StudentID, Department=@Department, Age=@Age
WHERE ID=@ID";

                    SqlCommand cmd = new SqlCommand(updateQuery, con);
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@StudentID", studentID);
                    cmd.Parameters.AddWithValue("@Department", department);
                    cmd.Parameters.AddWithValue("@Age", age);
                    cmd.Parameters.AddWithValue("@ID", id);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                        MessageBox.Show("Data updated successfully.");
                    else
                        MessageBox.Show("No data was updated.");
                }
            }
        }

        private void Remove_Pre_ACC_Click(object sender, EventArgs e)
        {
            if (GridViewMem.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row first.");
                return;
            }

            DataGridViewRow row = GridViewMem.SelectedRows[0];

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this record?",
                "Confirm Delete",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
                return;

            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-IILFUCP\SQLEXPRESS;Initial Catalog=UniversityClubDB;Integrated Security=True;Encrypt=False"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM BracAC_President WHERE ID=@ID", con);
                cmd.Parameters.AddWithValue("@ID", row.Cells["ID"].Value);
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                    MessageBox.Show("Data deleted successfully.");
                else
                    MessageBox.Show("Delete failed.");
            }
        }

        private void Add_Pre_ACC_Click(object sender, EventArgs e)
        {
            if (GridViewMem.DataSource == null)
            {
                MessageBox.Show("Please load the presidents first before adding a new president.",
                                "Load First",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }
            DataTable dt = (DataTable)GridViewMem.DataSource;

            DataRow newRow = dt.NewRow();
            newRow["ID"] = 0;
            newRow["FirstName"] = "";
            newRow["LastName"] = "";
            newRow["Email"] = "";
            newRow["Phone"] = DBNull.Value;
            newRow["Gender"] = "";
            newRow["Password"] = "";
            newRow["StudentID"] = "";
            newRow["Department"] = "";
            newRow["Age"] = DBNull.Value;

            dt.Rows.Add(newRow);
            GridViewMem.CurrentCell = GridViewMem.Rows[dt.Rows.Count - 1].Cells["FirstName"];
        }
    }
}
