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
    public partial class President_ABC_App : Form
    {
        public President_ABC_App()
        {
            InitializeComponent();
        }

        private void Member_Click(object sender, EventArgs e)
        {
            President_ABC_Mem Event = new President_ABC_Mem();
            Event.Show();
            this.Hide();
        }

        private void Event_Click(object sender, EventArgs e)
        {
            President_ABC_Event Event = new President_ABC_Event();
            Event.Show();
            this.Hide();
        }

        private void cross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Goback_Click(object sender, EventArgs e)
        {
            AIUBclub clubPanel = new AIUBclub();
            clubPanel.Show();
            this.Hide();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            AIUBclub clubPanel = new AIUBclub();
            clubPanel.Show();
            this.Hide();
        }

        private void Load_App_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(
        @"Data Source=DESKTOP-IILFUCP\SQLEXPRESS;
          Initial Catalog=UniversityClubDB;
          Integrated Security=True;Encrypt=False"))
            {
                string query = @"
SELECT ApplicantID, FirstName, LastName, Email, Phone, StudentID, Department, Gender, Status,Password, IsActive
FROM ABC_Applicants
WHERE IsActive = 1";


                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                GridViewMem.DataSource = dt;

                if (GridViewMem.Columns["ApplicantID"] != null)
                    GridViewMem.Columns["ApplicantID"].Visible = false;
            }
        }

        private void Reject_Click(object sender, EventArgs e)
        {
            if (GridViewMem.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to reject.");
                return;
            }

            int applicantId = Convert.ToInt32(GridViewMem.SelectedRows[0].Cells["ApplicantID"].Value);

            string tableName = "";

            string university = Session.University?.Trim().ToUpper();
            string club = Session.Club?.Trim().ToUpper();

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
                MessageBox.Show("Club table not found.");
                return;
            }

            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-IILFUCP\SQLEXPRESS;Initial Catalog=UniversityClubDB;Integrated Security=True;Encrypt=False"))
            {
                try
                {
                    con.Open();

                    // Update status and mark as inactive
                    string query = $@"
                UPDATE [{tableName}]
                SET Status = 'Rejected', IsActive = 0
                WHERE ApplicantID = @id";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", applicantId);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Applicant rejected successfully.");
                        // Remove from grid immediately
                        GridViewMem.Rows.RemoveAt(GridViewMem.SelectedRows[0].Index);
                    }
                    else
                    {
                        MessageBox.Show("Failed to reject applicant.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                }
            }
        }

        private void Viva_Click(object sender, EventArgs e)
        {
            if (GridViewMem.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an applicant to accept.");
                return;
            }

            int applicantId = Convert.ToInt32(GridViewMem.SelectedRows[0].Cells["ApplicantID"].Value);

            using (SqlConnection con = new SqlConnection(
                @"Data Source=DESKTOP-IILFUCP\SQLEXPRESS;
          Initial Catalog=UniversityClubDB;
          Integrated Security=True;Encrypt=False"))
            {
                try
                {
                    con.Open();

                    SqlTransaction transaction = con.BeginTransaction();

                    try
                    {
                        // Insert selected applicant into ACC_Member
                        string insertQuery = @"
INSERT INTO ABC_Member
(FirstName, LastName, Email, Phone, Department, Gender, Password)
SELECT FirstName, LastName, Email, Phone, Department, Gender, Password
FROM ABC_Applicants
WHERE ApplicantID = @id";

                        SqlCommand insertCmd = new SqlCommand(insertQuery, con, transaction);
                        insertCmd.Parameters.AddWithValue("@id", applicantId);
                        insertCmd.ExecuteNonQuery();

                        // Update applicant status
                        string updateQuery = @"
                UPDATE ABC_Applicants
                SET Status = 'Accepted', IsActive = 0
                WHERE ApplicantID = @id";

                        SqlCommand updateCmd = new SqlCommand(updateQuery, con, transaction);
                        updateCmd.Parameters.AddWithValue("@id", applicantId);
                        updateCmd.ExecuteNonQuery();

                        transaction.Commit();

                        MessageBox.Show("Applicant accepted successfully.");

                        // Remove from grid
                        GridViewMem.Rows.RemoveAt(GridViewMem.SelectedRows[0].Index);
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                }
            }
        }
    }

}

