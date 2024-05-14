

namespace Main
{
    public abstract class Cell
    {
        public int X { get; set; }
        public int Y { get; set; }
        public bool IsRevealed { get; set; }
        public bool IsFlagged { get; set; }

        public Cell(int x, int y)
        {
            X = x;
            Y = y;
        }
        public event Action OnClick = delegate { };

        protected void RaiseOnClick()
        {
            OnClick?.Invoke();
        }
        public void Open()
        {
            IsRevealed = true;
            RaiseOnClick();

            Game.Instance.IsGameWon();


            if (!IsFlagged && this is EmptyCell)
            {
                Game.Instance.Board.OpenEmptyAdjacentCells(this);
            }
        }
        public abstract void Click();
        public void RightClick()
        {
            // Перемикаємо стан прапорця
            if (!IsRevealed)
            {
                IsFlagged = !IsFlagged;
            }
            Game.Instance.CellFlagged();
            RaiseOnClick();
        }
        public void IsFirstClick()
        {
            if (Game.Instance.ClicksMade == 0)
            {
                Game.Instance.StartGame();
            }
        }
    }
}