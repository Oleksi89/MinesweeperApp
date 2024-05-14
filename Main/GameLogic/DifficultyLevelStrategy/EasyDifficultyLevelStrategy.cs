namespace Main
{
    public class EasyDifficultyLevelStrategy : IDifficultyLevelStrategy
    {
        public DifficultyLevel GetDifficultyLevel()
        {
            return new DifficultyLevel(9, 9, 10);
        }
    }
}