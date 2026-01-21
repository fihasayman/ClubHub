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
    public partial class President_IMA_Mem : Form
    {
        public President_IMA_Mem()
        {
            InitializeComponent();
        }

        private void Goback_Click(object sender, EventArgs e)
        {
            IUBClub clubPanel = new IUBClub();
            clubPanel.Show();
            this.Hide();
        }

        private void cross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void Applicant_IMA_Click(object sender, EventArgs e)
        {
            President_IMA_App applicant = new President_IMA_App();
            applicant.Show();
            this.Hide();
        }

        private void Event_IMA_Click(object sender, EventArgs e)
        {
            President_IMA_Event imaEvent = new President_IMA_Event();
            imaEvent.Show();
            this.Hide();
        }

        private void Load_Mem_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(
    @"Data Source=DESKTOP-IILFUCP\SQLEXPRESS;
          Initial Catalog=UniversityClubDB;
          Integrated Security=True;Encrypt=False"))
            {
                string query = @"
SELECT MemberID, FirstName, LastName, Email, Phone, Department, Gender, Password
FROM IUBMA_Member";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                GridViewMem.DataSource = dt;

                if (GridViewMem.Columns["MemberID"] != null)
                    GridViewMem.Columns["MemberID"].Visible = false;
            }
        }

        private void Update_Mem_Click(object sender, EventArgs e)
        {
          
            GridViewMem.CommitEdit(DataGridViewDataErrorContexts.Commit);
            GridViewMem.EndEdit();

          
            if (GridViewMem.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a row first.");
                return;
            }

            DataRowView rowView =
                GridViewMem.SelectedRows[0].DataBoundItem as DataRowView;
            if (rowView == null) return;

            DataRow row = rowView.Row;

            int memberId = Convert.ToInt32(row["MemberID"]);

            string firstName = row["FirstName"].ToString().Trim();
            string lastName = row["LastName"].ToString().Trim();
            string email = row["Email"].ToString().Trim();
            string phone = row["Phone"].ToString().Trim();
            string department = row["Department"].ToString().Trim();
            string gender = row["Gender"].ToString().Trim();
            string password = row["Password"].ToString().Trim();

            if (firstName == "" || email == "" || phone == "" || password == "")
            {
                MessageBox.Show("First Name, Email,Password and Phone are required.");
                return;
            }

            using (SqlConnection con = new SqlConnection(
    @"Data Source=DESKTOP-IILFUCP\SQLEXPRESS;
Initial Catalog=UniversityClubDB;
Integrated Security=True;Encrypt=False"))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

               
                if (memberId == 0)
                {
                    cmd.CommandText = @"
            INSERT INTO dbo.IUBMA_Member
            (FirstName, LastName, Email, Phone, Department, Gender, Password)
            VALUES
            (@FirstName, @LastName, @Email, @Phone, @Department, @Gender,  @Password)";
                }
                else
                {
                    cmd.CommandText = @"
            UPDATE dbo.IUBMA_Member
            SET
                FirstName=@FirstName,
                LastName=@LastName,
                Email=@Email,
                Phone=@Phone,
                Department=@Department,
                Gender=@Gender,
                Password=@Password
            WHERE MemberID=@Id";

                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = memberId;
                }

                cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = firstName;
                cmd.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = lastName;
                cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = email;
                cmd.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = phone;
                cmd.Parameters.Add("@Department", SqlDbType.NVarChar).Value = department;
                cmd.Parameters.Add("@Gender", SqlDbType.NVarChar).Value = gender;
                cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = password;

                int rows = cmd.ExecuteNonQuery();

                MessageBox.Show(rows > 0
                    ? "Member saved successfully."
                    : "No changes saved.");
            }


        }

        private void Remove_Mem_Click(object sender, EventArgs e)
        {
            if (GridViewMem.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a member first.");
                return;
            }

            int memberId = Convert.ToInt32(GridViewMem.SelectedRows[0].Cells["MemberID"].Value);

            using (SqlConnection con = new SqlConnection(
                @"Data Source=DESKTOP-IILFUCP\SQLEXPRESS;
      Initial Catalog=UniversityClubDB;
      Integrated Security=True;Encrypt=False"))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM dbo.IUBMA_Member WHERE MemberID = @Id", con);

                cmd.Parameters.AddWithValue("@Id", memberId);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                    MessageBox.Show("Member removed successfully.");
                else
                    MessageBox.Show("Operation failed.");
            }

            Load_Mem.PerformClick();
        }

        private void Add_Mem_Click(object sender, EventArgs e)
        {
            DataTable dt = GridViewMem.DataSource as DataTable;

            if (dt == null)
            {
                MessageBox.Show("Load members first.");
                return;
            }

            DataRow newRow = dt.NewRow();

            newRow["MemberID"] = 0;
            newRow["FirstName"] = "";
            newRow["LastName"] = "";
            newRow["Email"] = "";
            newRow["Phone"] = "";
            newRow["Department"] = "";
            newRow["Gender"] = "";
            newRow["Password"] = "";

            dt.Rows.Add(newRow);

            GridViewMem.CurrentCell =
                GridViewMem.Rows[dt.Rows.Count - 1].Cells["FirstName"];

            GridViewMem.BeginEdit(true);
        }
    }
}
