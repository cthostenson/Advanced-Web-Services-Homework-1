using System;
using System.Linq;
using System.Collections.Generic;

namespace ModasSeedData
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // first create Locations list
            List<Location> Locations = new List<Location>()
            {
                //new Location { LocationId = 1, Name = "Front Door"},
                // TODO: Add locations
            };
            // create date object containing current date/time
            DateTime localDate = DateTime.Now;
            // TODO: subtract 6 months from date
            // eventDate = ???
            // TODO: instantiate Random class
            // Random rnd = ???
            // TODO: create list to store events (Events)
            // loop for each day in the range from 6 months ago to today
            //while (eventDate < localDate)
            //{
            // TODO: random between 0 and 5 determines the number of events to occur on a given day
            // TODO: a sorted list will be used to store daily events sorted by date/time - each time an event is added, the list is re-sorted
            // TODO: for loop to generate times for each event
            // TODO: random between 0 and 23 for hour of the day
            // TODO: random between 0 and 59 for minute of the day
            // TODO: random between 0 and 59 for seconds of the day
            // TODO: random location (use Locations)
            // TODO: create date/time for event
            // TODO: create event from date/time and location
            // TODO: add daily event to sorted list
            // TODO: loop thru sorted list for daily events
            // add daily event to Events
            // TODO: add 1 day to eventDate
            //}
            // TODO: loop thru Events
            // TODO: display event at console
        }
    }

    public class Location
    {
        public int LocationId { get; set; }
        public string Name { get; set; }
    }

    public class Event
    {
        public int EventId { get; set; }
        public DateTime TimeStamp { get; set; }
        public bool Flagged { get; set; }
        // foreign key for location 
        public int LocationId { get; set; }
        // navigation property
        public Location Location { get; set; }
    }
}
