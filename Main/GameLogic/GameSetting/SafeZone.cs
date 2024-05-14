namespace Main
{
    public class SafeZone : IGameSetting
    {
        public void Apply(Game game)
        {
            // Clicking on a number opens all unrevealed adjacent cells
            game.Settings.ClickNumberOpensAdjacentCells = true;
        }
    }
}