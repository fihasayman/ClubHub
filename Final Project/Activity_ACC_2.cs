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
    public partial class Activity_ACC_2 : Form
    {
        public Activity_ACC_2()
        {
            InitializeComponent();
        }

        private void cross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Go_Back_Click(object sender, EventArgs e)
        {
            President_ACC_Event president_ACC_Event = new President_ACC_Event();
            president_ACC_Event.Show();
            this.Hide();
        }

        private void Volunteer_Registration2_Click(object sender, EventArgs e)
        {
            Volunteer_Activity_ACC_2 volunteer_Activity_ACC_2 = new Volunteer_Activity_ACC_2();
            volunteer_Activity_ACC_2.Show();
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
              FROM ACC_Event2_Registration", con);

                DataTable dtReg = new DataTable();
                daReg.Fill(dtReg);

                dataGridView1.DataSource = dtReg;

                if (dataGridView1.Columns["RegistrationID"] != null)
                    dataGridView1.Columns["RegistrationID"].Visible = false;
            }
        }
    }
}
