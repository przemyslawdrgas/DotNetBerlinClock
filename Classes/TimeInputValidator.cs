using System;

namespace BerlinClock.Classes
{
    public class TimeInputValidator : ITimeInputValidator
    {
        public void Validate(TimeSpan timespan)
        {
            int miliseconds = (int)timespan.TotalMilliseconds;
            int maxMiliseconds = (int)TimeSpan.FromDays(1).TotalMilliseconds;

            if (timespan.Hours > 24 || timespan.Minutes > 59 || timespan.Seconds > 59 || miliseconds > maxMiliseconds)
                throw new ArgumentException();
        }
    }
}
