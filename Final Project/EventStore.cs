using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
   //Class representing a single event
    public class EventInfo
    {
        public string University { get; set; }
        public string Club { get; set; }
        public string EventName { get; set; }  // Unique per event
        public string Title { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public string MaxAttendees { get; set; }
        public string Volunteers { get; set; }
    }

    // Central store for all events — static so accessible anywhere
    public static class EventStore
    {
        private static List<EventInfo> events = new List<EventInfo>();

        // Add or update an event
        public static void SaveEvent(string university, string club, string eventName,
                                     string title, string date, string time,
                                     string location, string description,
                                     string maxAttendees, string volunteers)
        {
            EventInfo existing = events.Find(e => e.University == university &&
                                                 e.Club == club &&
                                                 e.EventName == eventName);
            if (existing != null)
            {
                // Update existing event
                existing.Title = title;
                existing.Date = date;
                existing.Time = time;
                existing.Location = location;
                existing.Description = description;
                existing.MaxAttendees = maxAttendees;
                existing.Volunteers = volunteers;
            }
            else
            {
                // Add new event
                events.Add(new EventInfo
                {
                    University = university,
                    Club = club,
                    EventName = eventName,
                    Title = title,
                    Date = date,
                    Time = time,
                    Location = location,
                    Description = description,
                    MaxAttendees = maxAttendees,
                    Volunteers = volunteers
                });
            }
        }

        // Get event by university, club, and event name
        public static EventInfo GetEvent(string university, string club, string eventName)
        {
            return events.Find(e => e.University == university &&
                                    e.Club == club &&
                                    e.EventName == eventName);
        }
    }

}
