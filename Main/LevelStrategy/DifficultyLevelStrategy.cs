using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public interface IDifficultyLevelStrategy
    {
        DifficultyLevel GetDifficultyLevel();
    }

    public class EasyDifficultyLevelStrategy : IDifficultyLevelStrategy
    {
        public DifficultyLevel GetDifficultyLevel()
        {
            return new DifficultyLevel(9, 9, 10);
        }
    }

    public class MediumDifficultyLevelStrategy : IDifficultyLevelStrategy
    {
        public DifficultyLevel GetDifficultyLevel()
        {
            return new DifficultyLevel(16, 16, 40);
        }
    }

    public class HardDifficultyLevelStrategy : IDifficultyLevelStrategy
    {
        public DifficultyLevel GetDifficultyLevel()
        {
            return new DifficultyLevel(30, 16, 99);
        }
    }

}
