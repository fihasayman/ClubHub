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
    public partial class Volunteer_Activity_ACC_1 : Form
    {
        public Volunteer_Activity_ACC_1()
        {
            InitializeComponent();
        }

        private void Go_Back_Click(object sender, EventArgs e)
        {
            President_ACC_Event president_ACC_Event = new President_ACC_Event();
            president_ACC_Event.Show();
            this.Hide();
        }

        private void Event_Registration1_Click(object sender, EventArgs e)
        {
            Activity_ACC_1 activity_ACC1 = new Activity_ACC_1();
            activity_ACC1.Show();
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

                SqlDataAdapter daVol = new SqlDataAdapter(
                    @"SELECT VolunteerID, FirstName, LastName, Email, Phone,
                     ExperienceSKills, Availability
              FROM ACC_Event1_Volunteer", con);

                DataTable dtVol = new DataTable();
                daVol.Fill(dtVol);

                dataGridView2.DataSource = dtVol;

                if (dataGridView2.Columns["VolunteerID"] != null)
                    dataGridView2.Columns["VolunteerID"].Visible = false;
            }
        }
    }
}
