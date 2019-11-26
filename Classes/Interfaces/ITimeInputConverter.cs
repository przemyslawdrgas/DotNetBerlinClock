using System;

namespace BerlinClock.Classes
{
    public interface ITimeInputConverter
    {
        TimeSpan ToTimeSpan(string aTime);
    }
}
