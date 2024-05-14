namespace Main
{
    [Serializable]
    public class MineCounter : IGameObserver
    {
        private Control mineCounterLabel;

        public MineCounter(Control mineCounterLabel)
        {
            this.mineCounterLabel = mineCounterLabel;
        }

        public void Update(string message)
        {
            if (message != "flagged" && message != "game prepared")
                return;

            if (!Game.Instance.GameInProgress && Game.Instance.Board != null)
            {
                int totalMines = Game.Instance.Board.TotalMines;
                mineCounterLabel.Text = totalMines.ToString().PadLeft(3, '0');
            }
            else if (Game.Instance.GameInProgress && Game.Instance.Board != null)
            {
                int flaggedCells = Game.Instance.Board.GetCells().Count(c => c.IsFlagged);
                int totalMines = Game.Instance.Board.TotalMines;
                mineCounterLabel.Text = (totalMines - flaggedCells).ToString().PadLeft(3, '0');
            }
            else
            {
                mineCounterLabel.Text = "000";
            }
        }
    }

}
