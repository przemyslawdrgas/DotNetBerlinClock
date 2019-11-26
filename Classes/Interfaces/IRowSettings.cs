using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Classes
{
    public interface IRowSettings
    {
        TimeSpan PeriodTime { get; }
        int ModuloDivisor { get; }
        int PeriodTimeMiliseconds { get; }
        int PeriodsCount { get; }
    }
}
