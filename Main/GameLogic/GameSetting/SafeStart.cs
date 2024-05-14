namespace Main
{
    public class SafeStart : IGameSetting
    {
        public void Apply(Game game)
        {
            // The first click is always on an empty cell
            game.Settings.FirstClickIsSafe = true;
        }
    }
}