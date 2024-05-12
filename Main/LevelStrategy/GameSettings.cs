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

        public bool FirstClickIsSafe { get; set; }
        public bool ClickNumberOpensAdjacentCells { get; set; }
        public bool ClickOnMineStartsDefuseCountdown { get; set; }
        public bool AllMinesFlaggedOpensRemainingCells { get; set; }

        public GameSettings(IDifficultyLevelStrategy difficultyLevelStrategy)
        {
            DifficultyLevelStrategy = difficultyLevelStrategy;
        }
    }

}
