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
    public partial class AIUB_ACC_Member : Form
    {
        public static AIUB_ACC_Member instance;
        //Event 1
        public Label ACC_ETitle1;
        public Label ACC_EDate;
        public Label ACC_ETime;
        public Label ACC_ELocation;
        public Label ACC_EDescription;
        public Label ACC_EMaxAttendees;
        public Label ACC_EVolunteers;

        //Event 2
        public Label ACC_Event_Title2;
        public Label ACC_EDate2;
        public Label ACC_Time2;
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
        public AIUB_ACC_Member()
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
            ACC_ETitle2 = ACC_ETitle2;
            ACC_EDate2 = ACC_Date2;
            ACC_ETime2 = ACC_Time2;
            ACC_ELocation2 = ACC_Location2;
            ACC_EDescription2 = ACC_Description2;
            ACC_EMaxAttendees2 = ACC_Attendees2;
            ACC_EVolunteers2 = ACC_Volunteers2;


            this.FormClosing += AIUB_ACC_Member_FormClosing;

            // Event 3
            ACC_ETitle3 = Title3;
            ACC_EDate3 = Date3;
            ACC_ETime3 = Time3;
            ACC_ELocation3 = Location3;
            ACC_EDescription3 = Description3;
            ACC_EMaxAttendees3 = MaxAttendees3;
            ACC_EVolunteers3 = Volunteers3;

        }
        private void AIUB_ACC_Member_FormClosing(object sender, FormClosingEventArgs e)
        {
            instance = null;
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

        private void Volunteer1_Click(object sender, EventArgs e)
        {
            Volunteer_Form_ACC_1 volunteerFormAcc1 = new Volunteer_Form_ACC_1();
            volunteerFormAcc1.ShowDialog();

        }

        private void Volunteer3_Click(object sender, EventArgs e)
        {
            Volunteer_Form_ACC_3 volunteerFormAcc3 = new Volunteer_Form_ACC_3();
            volunteerFormAcc3.ShowDialog();
        }

        private void Volunteer2_Click(object sender, EventArgs e)
        {
            Volunteer_Form_ACC_2 volunteerFormAcc2 = new Volunteer_Form_ACC_2();
            volunteerFormAcc2.ShowDialog();
        }

        private void Registration_ACC_2_Click(object sender, EventArgs e)
        {
            Registration_Form_ACC_1 registrationForm1 = new Registration_Form_ACC_1();
            registrationForm1.ShowDialog();
        }

        private void RegistrationACC1_Click(object sender, EventArgs e)
        {
            Registration_Form_ACC_2 registrationForm2 = new Registration_Form_ACC_2();
            registrationForm2.ShowDialog();
        }

        private void RegistrationACC3_Click(object sender, EventArgs e)
        {
            Registration_Form_ACC_3 registrationForm3 = new Registration_Form_ACC_3();
            registrationForm3.ShowDialog();
        }

        private void AIUB_ACC_Member_Load(object sender, EventArgs e)
        {
            var ev = EventStore.GetEvent("AIUB", "ACC", "Event 1");
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
            var ev2 = EventStore.GetEvent("AIUB", "ACC", "Event 2");
            if (ev2 != null)
            {
                ACC_ETitle2.Text = ev2.Title;
                ACC_EDate2.Text = ev2.Date;
                ACC_ETime2.Text = ev2.Time;
                ACC_Description2.Text = ev2.Location;
                ACC_Description2.Text = ev2.Description;
                ACC_Attendees2.Text = ev2.MaxAttendees;
                ACC_Volunteers2.Text = ev2.Volunteers;

            }

            var ev3 = EventStore.GetEvent("AIUB", "ACC", "Event 3");
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

