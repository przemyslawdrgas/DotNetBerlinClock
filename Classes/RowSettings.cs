using System;

namespace BerlinClock.Classes
{
    public class RowSettings : IRowSettings
    {
        private readonly TimeSpan _periodTime;
        private readonly int _periodsCount;

        public RowSettings(TimeSpan periodTime, int periodsCount)
        {
            _periodTime = periodTime;
            _periodsCount = periodsCount;
        }

        public TimeSpan PeriodTime => _periodTime;
        public int PeriodsCount => _periodsCount;
        public int ModuloDivisor => _periodsCount + 1;
        public int PeriodTimeMiliseconds => (int)_periodTime.TotalMilliseconds;
    }
}
