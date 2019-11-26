using System.Linq;

namespace BerlinClock.Classes
{
    public class FiveMinRowRenderer : RowRenderer, IMultiActiveSymbolRowRenderer
    {
        char _secondActiveSymbol;

        public FiveMinRowRenderer(char activeSymbol, char secondActiveSymbol, char inactiveSymbol) : base(activeSymbol, inactiveSymbol)
        {
            _secondActiveSymbol = secondActiveSymbol;
        }

        public char SecondActiveSymbol => _secondActiveSymbol;

        public override string Render(IRow row)
        {
            string result = string.Empty;

            foreach (IRowPiece piece in row.Pieces.OrderBy(x => x.Index))
            {
                char activeSymbol = piece.Index % 3 == 0 ? SecondActiveSymbol : ActiveSymbol;
                result += piece.State ? activeSymbol : InactiveSymbol;
            }

            return result;
        }
    }
}
