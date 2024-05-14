namespace Main
{
    public class HardDifficultyLevelStrategy : IDifficultyLevelStrategy
    {
        public DifficultyLevel GetDifficultyLevel()
        {
            return new DifficultyLevel(30, 16, 99);
        }
    }
}