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
    public partial class Activity_ROBU_2 : Form
    {
        public Activity_ROBU_2()
        {
            InitializeComponent();
        }

        private void cross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Go_Back_Click(object sender, EventArgs e)
        {
            President_ROBU_Event president_ROBU_Event = new President_ROBU_Event();
            president_ROBU_Event.Show();
            this.Hide();
        }

        private void Volunteer_Registration2_Click(object sender, EventArgs e)
        {
            Volunteer_ROBU_2 volunteer_ROBU_2 = new Volunteer_ROBU_2();
            volunteer_ROBU_2.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Go_Back_Click_1(object sender, EventArgs e)
        {
            President_ROBU_Event president_ROBU_Event = new President_ROBU_Event();
            president_ROBU_Event.Show();
            this.Hide();
        }

        private void cross_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Volunteer_Registration1_Click(object sender, EventArgs e)
        {
            Volunteer_ROBU_2 volunteer_ROBU_2 = new Volunteer_ROBU_2();
            volunteer_ROBU_2.Show();
            this.Hide();
        }

        private void Add_Event_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(
        @"Data Source=DESKTOP-IILFUCP\SQLEXPRESS;
          Initial Catalog=UniversityClubDB;
          Integrated Security=True;Encrypt=False"))
            {
                con.Open();

                SqlDataAdapter daReg = new SqlDataAdapter(
                    @"SELECT RegistrationID, FirstName, LastName, Email, Phone,
                     StudentID, Semester, Department, ClubMember
              FROM ROBU_Event2_Registration", con);

                DataTable dtReg = new DataTable();
                daReg.Fill(dtReg);

                dataGridView1.DataSource = dtReg;

                if (dataGridView1.Columns["RegistrationID"] != null)
                    dataGridView1.Columns["RegistrationID"].Visible = false;
            }
        }
    }
}
