

namespace Main
{
    public class EmptyCell : Cell
    {
        public EmptyCell(int x, int y) : base(x, y) { }
        public override void Click()
        {
            IsFirstClick();

            if (!IsFlagged && !IsRevealed)
            {
                Game.Instance.IncrementClicksMade();
                Open();

            }
        }
    }
}