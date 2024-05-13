using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class GameHistoryEntry
    {
        public string DifficultyLevel { get; set; }
        public bool FirstClickIsSafe { get; set; }
        public bool ClickNumberOpensAdjacentCells { get; set; }
        public bool ClickOnMineStartsDefuseCountdown { get; set; }
        public bool AllMinesFlaggedOpensRemainingCells { get; set; }
        public double PercentageOfCorrectlyOpenedCells { get; set; }
        public DateTime EndTime { get; set; }
        public string Result { get; set; }
        public int ClicksMade { get; set; }
        public Double GameTime { get; set; }
    }
}

