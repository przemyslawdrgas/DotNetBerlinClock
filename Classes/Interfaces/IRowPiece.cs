namespace BerlinClock.Classes
{
    public interface IRowPiece
    {
        int Index { get; }
        bool State { get; set; }
    }
}
