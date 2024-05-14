namespace Main
{
    public class MediumDifficultyLevelStrategy : IDifficultyLevelStrategy
    {
        public DifficultyLevel GetDifficultyLevel()
        {
            return new DifficultyLevel(16, 16, 40);
        }
    }
}