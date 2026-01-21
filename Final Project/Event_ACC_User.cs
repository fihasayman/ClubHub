using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Final_Project
{
    public partial class Event_ACC_User : Form
    {
        public static Event_ACC_User instance;
        //Event 1
        public Label ACC_ETitle1;
        public Label ACC_EDate;
        public Label ACC_ETime;
        public Label ACC_ELocation;
        public Label ACC_EDescription;
        public Label ACC_EMaxAttendees;
        public Label ACC_EVolunteers;

        //Event 2
        public Label ACC_Title2;
        public Label ACC_Date2;
        public Label ACC_Time2;
        public Label ACC_Location2;
        public Label ACC_DescriptionE2;
        public Label ACC_MaxAttendees2;
        public Label ACC_Volunteers2;

        //Event 3
        public Label ACC_ETitle3;
        public Label ACC_EDate3;
        public Label ACC_ETime3;
        public Label ACC_ELocation3;
        public Label ACC_EDescription3;
        public Label ACC_EMaxAttendees3;
        public Label ACC_EVolunteers3;
        public Event_ACC_User()
        {
            InitializeComponent();
            instance = this;
            //Event 1
            ACC_ETitle1 = ACC_Title1;
            ACC_EDate = ACC_Date1;
            ACC_ETime = ACC_Time1;
            ACC_ELocation = ACC_Location1;
            ACC_EDescription = ACC_Description1;
            ACC_EMaxAttendees = ACC_Attendees1;
            ACC_EVolunteers = ACC_Volunteer1;

            //Event 2
            ACC_Title2 = ACC_ETitle2;
            ACC_Date2 = ACC_EDate2;
            ACC_Time2 = ACC_ETime2;
            ACC_Location2 = ACC_ELocation2;
            ACC_DescriptionE2 = ACC_EDescription2;
            ACC_MaxAttendees2 = ACC_EAttendees2;
            ACC_Volunteers2 = ACC_EVolunteers2;

            //Event 3
            ACC_ETitle3 = Title3;
            ACC_EDate3 = Date3;
            ACC_ETime3 = Time3;
            ACC_ELocation3 = Location3;
            ACC_EDescription3 = Description3;
            ACC_EMaxAttendees3 = Attendees3;
            ACC_EVolunteers3 = Volunteer3;
        }

        private void cross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Goback_Click(object sender, EventArgs e)
        {
            AIUBuser aiubuser = new AIUBuser();
            aiubuser.Show();
            this.Hide();
        }

        private void RegistrationACC3_Click(object sender, EventArgs e)
        {
            Registration_Form_ACC_3 registration_Form_ACC_3 = new Registration_Form_ACC_3();
            registration_Form_ACC_3.ShowDialog();
        }

        private void RegistrationACC1_Click(object sender, EventArgs e)
        {
            Registration_Form_ACC_1 registration_Form_ACC_1 = new Registration_Form_ACC_1();
            registration_Form_ACC_1.ShowDialog();
        }

        private void RegistrationACC2_Click(object sender, EventArgs e)
        {
            Registration_Form_ACC_2 registration_Form_ACC_2 = new Registration_Form_ACC_2();
            registration_Form_ACC_2.ShowDialog();
        }

        private void Event_ACC_User_Load(object sender, EventArgs e)
        {
            string university = "AIUB";
            string club = "ACC";
            string eventName = "Event 1";

            var ev = EventStore.GetEvent(university, club, eventName);
            if (ev != null)
            {
                ACC_ETitle1.Text = ev.Title;
                ACC_EDate.Text = ev.Date;
                ACC_ETime.Text = ev.Time;
                ACC_ELocation.Text = ev.Location;
                ACC_EDescription.Text = ev.Description;
                ACC_EMaxAttendees.Text = ev.MaxAttendees;
                ACC_EVolunteers.Text = ev.Volunteers;
            }

            var ev2 = EventStore.GetEvent(university, club, "Event 2");
            if (ev2 != null)
            {
                ACC_ETitle2.Text = ev2.Title;
                ACC_EDate2.Text = ev2.Date;
                ACC_ETime2.Text = ev2.Time;
                ACC_ELocation2.Text = ev2.Location;
                ACC_EDescription2.Text = ev2.Description;
                ACC_MaxAttendees2.Text = ev2.MaxAttendees;
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
    }
}

