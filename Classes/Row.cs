using System.Collections.Generic;

namespace BerlinClock.Classes
{
    public class Row : IRow
    {
        public Row(int level, IRowSettings settings, IRowRenderer renderer)
        {
            Level = level;
            Settings = settings;
            Renderer = renderer;
            CreatePieces();
        }

        public int Level { get; set; }
        public List<IRowPiece> Pieces { get; set; }
        public IRowSettings Settings { get; set; }
        public IRowRenderer Renderer { get; set; }

        private void CreatePieces()
        {
            Pieces = new List<IRowPiece>();
            for (int i = 1; i <= Settings.PeriodsCount; i++)
            {
                Pieces.Add(new RowPiece(i));
            }
        }

        public void SetStates(int timeInMiliseconds)
        {
            var lastIndexToActivate = (timeInMiliseconds / Settings.PeriodTimeMiliseconds) % Settings.ModuloDivisor;
            foreach (IRowPiece piece in Pieces)
            {
                if (piece.Index <= lastIndexToActivate)
                    piece.State = true;
                else
                    piece.State = false;
            }
        }
    }
}
