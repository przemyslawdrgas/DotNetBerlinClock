namespace BerlinClock.Classes
{
    public class RowPiece : IRowPiece
    {
        private int _index;

        public RowPiece(int index)
        {
            _index = index;
        }

        public int Index => _index;
        public bool State { get; set; }
    }
}
