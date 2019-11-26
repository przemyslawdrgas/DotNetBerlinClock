using System.Linq;

namespace BerlinClock.Classes
{
    public class RowRenderer : IRowRenderer
    {
        protected char _activeSymbol;
        protected char _inactiveSymbol;

        public RowRenderer(char activeSymbol, char inactiveSymbol)
        {
            _activeSymbol = activeSymbol;
            _inactiveSymbol = inactiveSymbol;
        }

        public char ActiveSymbol => _activeSymbol;
        public char InactiveSymbol => _inactiveSymbol;

        public virtual string Render(IRow row)
        {
            string result = string.Empty;
            foreach (IRowPiece piece in row.Pieces.OrderBy(x => x.Index))
            {
                result += piece.State ? ActiveSymbol : InactiveSymbol;
            }

            return result;
        }
    }
}
