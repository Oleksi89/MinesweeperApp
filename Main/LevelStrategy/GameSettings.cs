using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class GameSettings
    {
        public IDifficultyLevelStrategy DifficultyLevelStrategy { get; set; }

        public GameSettings(IDifficultyLevelStrategy difficultyLevelStrategy)
        {
            DifficultyLevelStrategy = difficultyLevelStrategy;
        }
    }

}
