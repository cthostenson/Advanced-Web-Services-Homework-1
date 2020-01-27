using System;
using System.Collections.Generic;

namespace dates
{
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
        public int LocationId { get; set; }
        public Location Location { get; set; }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            DateTime now = DateTime.Now;
   
            List<Event> events = new List<Event>();

            List<Location> Locations = new List<Location>() {
                new Location { LocationId = 1, Name = "Front Door"},
                new Location { LocationId = 2, Name = "Rear Door"},
                new Location { LocationId = 3, Name = "Office"},
            };

            DateTime startDate = now.AddMonths(-6);

            while (startDate < now) {
                SortedList<DateTime, Event> dailyEvents = new SortedList<DateTime, Event>();
                int numberOfEvents = random.Next(0, 5);
                for (int i = 0; i < numberOfEvents; i++) {
                    int hour = random.Next(0, 24);
                    int minute = random.Next(0, 60);
                    int second = random.Next(0, 60);
                    int location = random.Next(0, Locations.Count);
                    DateTime date = new DateTime(startDate.Year, startDate.Month, startDate.Day, hour, minute, second);
                    Event newEvent = new Event { Flagged = false, Location = Locations[location], LocationId = Locations[location].LocationId, TimeStamp = date };
                    dailyEvents.Add(date, newEvent);
                }

                foreach (var de in dailyEvents) {
                    events.Add(de.Value);
                }

                startDate = startDate.AddDays(1);
            }

            DateTime earliestTimeStamp = new DateTime();
            var firstFlag = false;

            foreach (Event e in events) {
                Console.WriteLine(e.TimeStamp + " - " + e.Location.Name);
                if(firstFlag == false) {
                    earliestTimeStamp = e.TimeStamp;
                    firstFlag = true;
                }
            }

            TimeSpan diff = earliestTimeStamp.Subtract(now);

            Console.WriteLine("\nData Recorded Over The Last: ");
            Console.WriteLine("Days: " + Math.Abs(diff.Days));
            Console.WriteLine("Hours: " + Math.Abs(diff.Hours));
            Console.WriteLine("Minutes: " + Math.Abs(diff.Minutes));
            Console.WriteLine("Seconds: " + Math.Abs(diff.Seconds));
            Console.WriteLine("Milliseconds: " + Math.Abs(diff.Milliseconds));

            Console.WriteLine("< Press Enter To Exit >");
            Console.ReadLine();
        }

    }

}
