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
    public partial class Volunteer_Activity_ABC : Form
    {
        public Volunteer_Activity_ABC()
        {
            InitializeComponent();
        }

        private void cross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            President_ABC_Event president = new President_ABC_Event();
            president.Show();
            this.Hide();

        }

        private void Event_Registration_Click(object sender, EventArgs e)
        {
            Activity_ABC activity_ABC = new Activity_ABC();
            activity_ABC.Show();
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
              FROM ABC_Event1_Volunteer", con);

                DataTable dtVol = new DataTable();
                daVol.Fill(dtVol);

                dataGridView1.DataSource = dtVol;

                if (dataGridView1.Columns["VolunteerID"] != null)
                    dataGridView1.Columns["VolunteerID"].Visible = false;
            }
        }
    }
}
