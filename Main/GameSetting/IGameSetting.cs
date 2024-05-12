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
            // Перший клік завжди на пусту клітинку
            game.Settings.FirstClickIsSafe = true;
        }
    }

    public class SafeZone : IGameSetting
    {
        public void Apply(Game game)
        {
            // Клік на цифру відкриває всі невідкриті сусідні клітинки
            game.Settings.ClickNumberOpensAdjacentCells = true;
        }
    }

    public class Defuse : IGameSetting
    {
        public void Apply(Game game)
        {
            // Клік на міну не закінчує гру
            game.Settings.ClickOnMineStartsDefuseCountdown = true;
        }
    }

    public class OpenRemaining : IGameSetting
    {
        public void Apply(Game game)
        {
            // Коли всі міни позначені, можна відкрити всі залишені клітинки
            game.Settings.AllMinesFlaggedOpensRemainingCells = true;
        }
    }

}
