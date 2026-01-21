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
    public partial class President_ACC_Event : Form
    {
        public static President_ACC_Event instance;
        //Event 1
        public Label ACC_ETitle1;
        public Label ACC_EDate;
        public Label ACC_ETime;
        public Label ACC_ELocation;
        public Label ACC_EDescription;
        public Label ACC_EMaxAttendees;
        public Label ACC_EVolunteers;
        //Event 2
        public Label ACC_ETitle2;
        public Label ACC_EDate2;
        public Label ACC_ETime2;
        public Label ACC_ELocation2;
        public Label ACC_EDescription2;
        public Label ACC_EMaxAttendees2;
        public Label ACC_EVolunteers2;
        //Event 3
        public Label ACC_ETitle3;
        public Label ACC_EDate3;
        public Label ACC_ETime3;
        public Label ACC_ELocation3;
        public Label ACC_EDescription3;
        public Label ACC_EMaxAttendees3;
        public Label ACC_EVolunteers3;
        public President_ACC_Event()
        {
            InitializeComponent();
            instance = this;
            //Event 1
            ACC_ETitle1 = ACC_PTitle1;
            ACC_EDate = ACC_PDate1;
            ACC_ETime = ACC_PTime1;
            ACC_ELocation = ACC_PLocation1;
            ACC_EDescription = ACC_PDescription1;
            ACC_EMaxAttendees = ACC_PAttendees1;
            ACC_EVolunteers = ACC_PVolunteer1;

            //Event 2
            ACC_ETitle2 = ACC_PTitle2;
            ACC_EDate2 = ACC_PTime2;
            ACC_ETime2 = ACC_PTime2;
            ACC_ELocation2 = ACC_PLocation2;
            ACC_EDescription2 = ACC_PDescription2;
            ACC_EMaxAttendees2 = ACC_PAttendees2;
            ACC_EVolunteers2 = ACC_PVolunteer2;

            //Event 3
            ACC_ETitle3 = ACC_PTitle3;
            ACC_EDate3 = ACC_PDate3;
            ACC_ETime3 = ACC_PTime3;
            ACC_ELocation3 = ACC_PLocation3;
            ACC_EDescription3 = ACC_PDescription3;
            ACC_EMaxAttendees3 = ACC_PAttendees3;
            ACC_EVolunteers3 = ACC_PVolunteer3;

        }

        private void cross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Applicant_Click(object sender, EventArgs e)
        {
            President_ACC_App applicant = new President_ACC_App();
            applicant.Show();
            this.Hide();
        }

        private void Member_Click(object sender, EventArgs e)
        {
            President_ACC_Mem member = new President_ACC_Mem();
            member.Show();
            this.Hide();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            Edit_Event editEvent = new Edit_Event();
            editEvent.ShowDialog();


        }

        private void Add_Event_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is currently unavailable.");
        }

        private void Edit2_Click(object sender, EventArgs e)
        {
            Edit2_Event edit2 = new Edit2_Event();
            edit2.ShowDialog();
        }

        private void Edit3_Click(object sender, EventArgs e)
        {
            Edit3_Event edit3 = new Edit3_Event();
            edit3.ShowDialog();
        }

        private void Goback_Click(object sender, EventArgs e)
        {
            AIUBclub clubPanel = new AIUBclub();
            clubPanel.Show();
            this.Hide();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void Activity_ACC_1_Click(object sender, EventArgs e)
        {
            Activity_ACC_1 Activity_ACC_1 = new Activity_ACC_1();
            Activity_ACC_1.Show();
            this.Hide();
        }

        private void Activity_ACC_2_Click(object sender, EventArgs e)
        {
            Activity_ACC_2 Activity_ACC_2 = new Activity_ACC_2();
            Activity_ACC_2.Show();
            this.Hide();
        }

        private void Activity_ACC_3_Click(object sender, EventArgs e)
        {
            Activity_ACC_3 Activity_ACC_3 = new Activity_ACC_3();
            Activity_ACC_3.Show();
            this.Hide();
        }

        private void Goback_Click_1(object sender, EventArgs e)
        {
            AIUBclub clubPanel = new AIUBclub();
            clubPanel.Show();
            this.Hide();
        }

        private void President_ACC_Event_Load(object sender, EventArgs e)
        {
            string university = "AIUB";
            string club = "ACC";
            string eventName = "Event 1";

            var ev1 = EventStore.GetEvent(university, club, "Event 1");
            if (ev1 != null)
            {
                ACC_ETitle1.Text = ev1.Title;
                ACC_EDate.Text = ev1.Date;
                ACC_ETime.Text = ev1.Time;
                ACC_ELocation.Text = ev1.Location;
                ACC_EDescription.Text = ev1.Description;
                ACC_EMaxAttendees.Text = ev1.MaxAttendees;
                ACC_EVolunteers.Text = ev1.Volunteers;
            }

            var ev2 = EventStore.GetEvent(university, club, "Event 2");
            if (ev2 != null)
            {
                ACC_ETitle2.Text = ev2.Title;
                ACC_EDate2.Text = ev2.Date;
                ACC_ETime2.Text = ev2.Time;
                ACC_ELocation2.Text = ev2.Location;
                ACC_EDescription2.Text = ev2.Description;
                ACC_EMaxAttendees2.Text = ev2.MaxAttendees;
                ACC_EVolunteers2.Text = ev2.Volunteers;
            }

            var ev3 = EventStore.GetEvent(university, club, "Event 3");
            if (ev3 != null)
            {
                ACC_ETitle3.Text = ev3.Title;
                ACC_EDate3.Text = ev3.Date;
                ACC_ETime3.Text = ev3.Time;
                ACC_ELocation3.Text = ev3.Location;
                ACC_EDescription3.Text = ev3.Description;
                ACC_EMaxAttendees3.Text = ev3.MaxAttendees;
                ACC_EVolunteers3.Text = ev3.Volunteers;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ACC_PDescription1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
