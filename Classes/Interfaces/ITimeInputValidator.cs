using System;

namespace BerlinClock.Classes
{
    public interface ITimeInputValidator
    {
        void Validate(TimeSpan timespan);
    }
}
