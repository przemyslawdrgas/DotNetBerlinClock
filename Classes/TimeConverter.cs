using BerlinClock.Classes;
using System;
using System.Collections.Generic;

namespace BerlinClock
{
    public class TimeConverter : ITimeConverter
    {
        private ITimeInputValidator _timeInputValidator;
        private ITimeInputConverter _timeInputConverter;

        public TimeConverter(ITimeInputValidator timeInputValidator, ITimeInputConverter timeInputConverter)
        {
            _timeInputValidator = timeInputValidator;
            _timeInputConverter = timeInputConverter;
            Rows = new List<IRow>();
        }

        public List<IRow> Rows { get; set; }

        public string convertTime(string aTime)
        {
            string result = string.Empty;

            TimeSpan timespan = _timeInputConverter.ToTimeSpan(aTime);
            _timeInputValidator.Validate(timespan);

            int miliseconds = (int)timespan.TotalMilliseconds;

            foreach (IRow row in Rows)
            {
                row.SetStates(miliseconds);
                result += row.Renderer.Render(row) + Environment.NewLine;
            }

            result = result.TrimEnd(Environment.NewLine.ToCharArray());
            return result;
        }
    }
}
