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
    public partial class Edit3_Event : Form
    {
        public static Edit3_Event instance;
        public TextBox Event_Title;
        public DateTimePicker DateTimePicker_Event_Date;
        public DateTimePicker DateTimePicker_Event_Time;
        public TextBox Event_Location;
        public TextBox Event_Description;
        public TextBox Event_Attendees;
        public TextBox Event_Volunteers;

        private string university = "AIUB";
        private string club = "ACC";
        private string eventName = "Event 3";

        public Edit3_Event()
        {
            InitializeComponent();
            Edit3_Event.instance = this;

            Event_Title = Event_title3;
           DateTimePicker_Event_Date = S_date;
            DateTimePicker_Event_Time = S_time;
            Event_Location = Location3;
            Event_Description = Description3;
           Event_Attendees = Max_Atten3;
            Event_Volunteers = Volunteer3;
        }

        private void cross_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save3_Click(object sender, EventArgs e)
        {
            string university = "AIUB";
            string club = "ACC";
            string eventName = "Event 3";

            var ev = EventStore.GetEvent(university, club, eventName);

            if (ev == null)
            {
                MessageBox.Show("Event not found!");
                return;
            }

            if (!string.IsNullOrWhiteSpace(Event_Title.Text))
                ev.Title = Event_Title.Text;

            if (!string.IsNullOrWhiteSpace(Event_Location.Text))
                ev.Location = Event_Location.Text;

            if (!string.IsNullOrWhiteSpace(Event_Description.Text))
                ev.Description = Event_Description.Text;

            if (!string.IsNullOrWhiteSpace(Event_Attendees.Text))
                ev.MaxAttendees = Event_Attendees.Text;

            if (!string.IsNullOrWhiteSpace(Event_Volunteers.Text))
                ev.Volunteers = Event_Volunteers.Text;

            ev.Date = DateTimePicker_Event_Date.Value.ToShortDateString();
            ev.Time = DateTimePicker_Event_Time.Value.ToShortTimeString();

            EventStore.SaveEvent(
                university,
                club,
                eventName,
                ev.Title,
                ev.Date,
                ev.Time,
                ev.Location,
                ev.Description,
                ev.MaxAttendees,
                ev.Volunteers
            );

            if (President_ACC_Event.instance != null)
            {
                President_ACC_Event.instance.ACC_ETitle3.Text = ev.Title;
                President_ACC_Event.instance.ACC_EDate3.Text = ev.Date;
                President_ACC_Event.instance.ACC_ETime3.Text = ev.Time;
                President_ACC_Event.instance.ACC_ELocation3.Text = ev.Location;
                President_ACC_Event.instance.ACC_EDescription3.Text = ev.Description;
                President_ACC_Event.instance.ACC_EMaxAttendees3.Text = ev.MaxAttendees;
                President_ACC_Event.instance.ACC_EVolunteers3.Text = ev.Volunteers;

            }

            if (Event_ACC_User.instance != null)
            {
                Event_ACC_User.instance.ACC_ETitle3.Text = ev.Title;
                Event_ACC_User.instance.ACC_EDate3.Text = ev.Date;
                Event_ACC_User.instance.ACC_ETime3.Text = ev.Time;
                Event_ACC_User.instance.ACC_ELocation3.Text = ev.Location;
                Event_ACC_User.instance.ACC_EDescription3.Text = ev.Description;
                Event_ACC_User.instance.ACC_EMaxAttendees3.Text = ev.MaxAttendees;
                Event_ACC_User.instance.ACC_EVolunteers3.Text = ev.Volunteers;
            }

            if (AIUB_ACC_Member.instance != null)
            {
                var memberPanel = AIUB_ACC_Member.instance;
                memberPanel.ACC_ETitle3.Text = ev.Title;
                memberPanel.ACC_EDate3.Text = ev.Date;
                memberPanel.ACC_ETime3.Text = ev.Time;
                memberPanel.ACC_ELocation3.Text = ev.Location;
                memberPanel.ACC_EDescription3.Text = ev.Description;
                memberPanel.ACC_EMaxAttendees3.Text = ev.MaxAttendees;
                memberPanel.ACC_EVolunteers3.Text = ev.Volunteers;
            }

            if (EventACC.instance != null)
            {
                var eventPanel = EventACC.instance;
                eventPanel.ACC_ETitle1.Text = ev.Title;
                eventPanel.ACC_EDate.Text = ev.Date;
                eventPanel.ACC_ETime.Text = ev.Time;
                eventPanel.ACC_ELocation.Text = ev.Location;
                eventPanel.ACC_EDescription.Text = ev.Description;
                eventPanel.ACC_EMaxAttendees.Text = ev.MaxAttendees;
                eventPanel.ACC_EVolunteers.Text = ev.Volunteers;
            }
            MessageBox.Show("Changes Saved Successfully!");
            this.Close();
        }

        private void S_date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Edit3_Event_Load(object sender, EventArgs e)
        {
            string university = "AIUB";
            string club = "ACC";
            string eventName = "Event 3";

            var ev = EventStore.GetEvent(university, club, eventName);


            if (ev == null)
            {
                EventStore.SaveEvent(
                    university,
                    club,
                    eventName,
                    "Industry visit to Augmedix Bangladesh",
                    DateTime.Now.ToShortDateString(),
                    DateTime.Now.ToShortTimeString(),
                    "Tejgaon",
                    "Referenced by the presence & guidance of professionals from Augmedix.",
                    "50", //Atendees 
                    "15"  //Volunteer
                );

                ev = EventStore.GetEvent(university, club, eventName);
            }

            Event_Title.Text = ev.Title;
            DateTimePicker_Event_Date.Value = DateTime.Parse(ev.Date);
            DateTimePicker_Event_Time.Value = DateTime.Parse(ev.Time);
            Event_Location.Text = ev.Location;
            Event_Description.Text = ev.Description;
            Event_Attendees.Text = ev.MaxAttendees;
            Event_Volunteers.Text = ev.Volunteers;
        }
    }
}
    
