namespace Main
{
    public class DifficultyLevel
    {
        public int Width { get; }
        public int Height { get; }
        public int Mines { get; }

        public DifficultyLevel(int width, int height, int mines)
        {
            Width = width;
            Height = height;
            Mines = mines;
        }
    }

}
