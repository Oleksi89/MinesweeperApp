
namespace Main
{
    public class NumberCell : Cell
    {
        public int AdjacentMines { get; set; }

        public NumberCell(int x, int y, int adjacentMines) : base(x, y)
        {
            AdjacentMines = adjacentMines;
        }

        public override void Click()
        {
            IsFirstClick();

            if (!IsFlagged)
            {
                if (Game.Instance.Settings.ClickNumberOpensAdjacentCells && IsRevealed)
                {
                    Game.Instance.OpenNumberAdjacentCells(X, Y);
                    Game.Instance.IncrementClicksMade();
                }
                else if (Game.Instance.Settings.FirstClickIsSafe && Game.Instance.ClicksMade == 0)
                {

                    Game.Instance.GenerateNewBoardAndClick(X, Y);

                }
                else
                {
                    Open();
                    Game.Instance.IncrementClicksMade();

                }
            }
        }
    }
}