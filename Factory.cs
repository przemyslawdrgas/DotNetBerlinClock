using BerlinClock.Classes;
using System;

namespace BerlinClock
{
    public static class Factory
    {
        public static IRow CreateRow(int level, IRowSettings minutesRowSettings, IRowRenderer YO)
        {
            return new Row(level, minutesRowSettings, YO);
        }

        public static IRowSettings CreateRowSettings(TimeSpan timeSpan, int periodsCount)
        {
            return new RowSettings(timeSpan, periodsCount);
        }

        public static IRowRenderer CreateRowRenderer(char activeSymbol, char inactiveSymbol)
        {
            return new RowRenderer(activeSymbol, inactiveSymbol);
        }

        public static IMultiActiveSymbolRowRenderer CreateIMultiActiveSymbolRowRenderer(char activeSymbol, char secondActiveSymbol, char inactiveSymbol)
        {
            return new FiveMinRowRenderer(activeSymbol, secondActiveSymbol, inactiveSymbol);
        }
    }
}
