using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Classes
{
    public interface IRow
    {
        int Level { get; set; }
        List<IRowPiece> Pieces { get; set; }
        IRowSettings Settings { get; set; }
        IRowRenderer Renderer { get; set; }

        void SetStates(int timeInMiliseconds);
    }
}
