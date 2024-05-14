namespace Main
{
    public class OpenRemaining : IGameSetting
    {
        public void Apply(Game game)
        {
            // When all mines are flagged, you can open all remaining cells
            game.Settings.AllMinesFlaggedOpensRemainingCells = true;
        }
    }
}