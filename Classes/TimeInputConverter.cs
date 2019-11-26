using System;
using System.Linq;

namespace BerlinClock.Classes
{
    public class TimeInputConverter : ITimeInputConverter
    {
        public TimeSpan ToTimeSpan(string aTime)
        {
            var timeSegments = aTime.Split(':').Select(Int32.Parse).ToList();
            var hours = timeSegments[0];
            var minutes = timeSegments[1];
            var seconds = timeSegments[2];
            TimeSpan timespan = new TimeSpan(hours, minutes, seconds);

            return timespan;
        }
    }
}
