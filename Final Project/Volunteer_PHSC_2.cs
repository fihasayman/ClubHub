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
    public partial class Volunteer_PHSC_2 : Form
    {
        public Volunteer_PHSC_2()
        {
            InitializeComponent();
        }

        private void Go_Back_Click(object sender, EventArgs e)
        {

        }

        private void Event_Registration2_Click(object sender, EventArgs e)
        {
            Activity_NPHSC_2 activity_NPHSC_2 = new Activity_NPHSC_2();
            activity_NPHSC_2.Show();
            this.Hide();
        }

        private void Go_Back_Click_1(object sender, EventArgs e)
        {
            President_PHSC_Event president_PHSC_Event = new President_PHSC_Event();
            president_PHSC_Event.Show();
            this.Hide();
        }

        private void cross_Click(object sender, EventArgs e)
        {
            this.Close();
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
              FROM PHSC_Event2_Volunteer", con);

                DataTable dtVol = new DataTable();
                daVol.Fill(dtVol);

                dataGridView1.DataSource = dtVol;

                if (dataGridView1.Columns["VolunteerID"] != null)
                    dataGridView1.Columns["VolunteerID"].Visible = false;
            }
        }
    }
}
