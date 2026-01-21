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
    public partial class Volunteer_IMA_2 : Form
    {
        public Volunteer_IMA_2()
        {
            InitializeComponent();
        }

        private void Go_Back_Click(object sender, EventArgs e)
        {
            President_IMA_Event president_IMA_Event = new President_IMA_Event();
            president_IMA_Event.Show();
            this.Hide();
        }

        private void Event_Registration_Click(object sender, EventArgs e)
        {
            Activity_IMA_2 activity_IMA2 = new Activity_IMA_2();
            activity_IMA2.Show();
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
              FROM IMA_Event2_Volunteer", con);

                DataTable dtVol = new DataTable();
                daVol.Fill(dtVol);

                dataGridView1.DataSource = dtVol;

                if (dataGridView1.Columns["VolunteerID"] != null)
                    dataGridView1.Columns["VolunteerID"].Visible = false;
            }
        }
    }
}
