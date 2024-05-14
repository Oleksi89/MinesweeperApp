
namespace Main
{
    public class MineCell : Cell
    {
        public MineCell(int x, int y) : base(x, y) { }
        public override void Click()
        {
            IsFirstClick();

            if (!IsFlagged && !IsRevealed)
            {

                if (Game.Instance.Settings.FirstClickIsSafe && Game.Instance.ClicksMade == 0)
                {

                    Game.Instance.GenerateNewBoardAndClick(X, Y);

                }
                else
                {
                    Game.Instance.IncrementClicksMade();
                    Open();
                    if (!Game.Instance.Settings.ClickOnMineDefuses == true)
                        Game.Instance.GameLost();


                }
            }
        }
    }
}