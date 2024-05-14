namespace Main
{
    public class Defuse : IGameSetting
    {
        public void Apply(Game game)
        {
            // Clicking on a mine does not end the game
            game.Settings.ClickOnMineDefuses = true;
        }
    }
}