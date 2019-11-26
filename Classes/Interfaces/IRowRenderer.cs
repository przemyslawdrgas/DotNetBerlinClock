namespace BerlinClock.Classes
{
    public interface IRowRenderer
    {
        char ActiveSymbol { get; }
        char InactiveSymbol { get; }

        string Render(IRow row);
    }
}
