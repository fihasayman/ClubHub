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
    public partial class Volunteer_NCEC_1 : Form
    {
        public Volunteer_NCEC_1()
        {
            InitializeComponent();
        }

        private void cross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Go_Back_Click(object sender, EventArgs e)
        {
            President_NCEC_Event president_NCEC_Event = new President_NCEC_Event();
            president_NCEC_Event.Show();
            this.Hide();
        }

        private void Event_Registration1_Click(object sender, EventArgs e)
        {
            Activity_NCEC_1 activity_NCEC_1 = new Activity_NCEC_1();
            activity_NCEC_1.Show();
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
              FROM NCEC_Event1_Volunteer", con);

                DataTable dtVol = new DataTable();
                daVol.Fill(dtVol);

                dataGridView1.DataSource = dtVol;

                if (dataGridView1.Columns["VolunteerID"] != null)
                    dataGridView1.Columns["VolunteerID"].Visible = false;
            }
        }
    }
}
