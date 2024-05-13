using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public interface IGameSetting
    {
        void Apply(Game game);
    }

    public class SafeStart : IGameSetting
    {
        public void Apply(Game game)
        {
            // The first click is always on an empty cell
            game.Settings.FirstClickIsSafe = true;
        }
    }

    public class SafeZone : IGameSetting
    {
        public void Apply(Game game)
        {
            // Clicking on a number opens all unrevealed adjacent cells
            game.Settings.ClickNumberOpensAdjacentCells = true;
        }
    }

    public class Defuse : IGameSetting
    {
        public void Apply(Game game)
        {
            // Clicking on a mine does not end the game
            game.Settings.ClickOnMineDefuses = true;
        }
    }

    public class OpenRemaining : IGameSetting
    {
        public void Apply(Game game)
        {
            // When all mines are flagged, you can open all remaining cells
            game.Settings.AllMinesFlaggedOpensRemainingCells = true;
        }
    }


}
