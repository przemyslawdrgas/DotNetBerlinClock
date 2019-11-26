using System;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using BerlinClock.Classes;
using System.Collections.Generic;

namespace BerlinClock
{
    [Binding]
    public class TheBerlinClockSteps
    {
        private ITimeConverter berlinClock = new TimeConverter(new TimeInputValidator(), new TimeInputConverter());
        private String theTime;

        TheBerlinClockSteps()
        {
            IRowRenderer YO = Factory.CreateRowRenderer('Y', 'O');
            IRowSettings minutesRowSettings = Factory.CreateRowSettings(new TimeSpan(0, 1, 0), 4);
            IRow minutesRow = Factory.CreateRow(0, minutesRowSettings, YO);

            IMultiActiveSymbolRowRenderer YRO = Factory.CreateIMultiActiveSymbolRowRenderer('Y', 'R', 'O');
            IRowSettings fiveMinutesRowSettings = Factory.CreateRowSettings(new TimeSpan(0, 5, 0), 11);
            IRow fiveMinutesRow = Factory.CreateRow(1, fiveMinutesRowSettings, YRO);

            IRowRenderer RO = Factory.CreateRowRenderer('R', 'O');
            IRowSettings hoursRowSettings = Factory.CreateRowSettings(new TimeSpan(1, 0, 0), 4);
            IRow hoursRow = Factory.CreateRow(2, hoursRowSettings, RO);

            IRowSettings fiveHoursRowSettings = Factory.CreateRowSettings(new TimeSpan(5, 0, 0), 4);
            IRow fiveHoursRow = Factory.CreateRow(3, fiveHoursRowSettings, RO);

            IRowRenderer OY = Factory.CreateRowRenderer('O', 'Y');
            IRowSettings secondsRowSettings = Factory.CreateRowSettings(new TimeSpan(0, 0, 1), 1);
            IRow secondsRow = Factory.CreateRow(4, secondsRowSettings, OY);

            List<IRow> rows = new List<IRow> { secondsRow, fiveHoursRow, hoursRow, fiveMinutesRow, minutesRow };
            berlinClock.Rows.AddRange(rows);
        }

        [When(@"the time is ""(.*)""")]
        public void WhenTheTimeIs(string time)
        {
            theTime = time;
        }

        [Then(@"the clock should look like")]
        public void ThenTheClockShouldLookLike(string theExpectedBerlinClockOutput)
        {
            Assert.AreEqual(berlinClock.convertTime(theTime), theExpectedBerlinClockOutput);
        }
    }
}
