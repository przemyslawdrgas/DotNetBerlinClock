using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Classes
{
    public interface IMultiActiveSymbolRowRenderer : IRowRenderer
    {
        char SecondActiveSymbol { get; }
    }
}
