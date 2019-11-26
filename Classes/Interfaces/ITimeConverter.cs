using BerlinClock.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BerlinClock
{
    public interface ITimeConverter
    {
        List<IRow> Rows { get; set; }
        String convertTime(String aTime);
    }
}
