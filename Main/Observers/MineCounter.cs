﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    [Serializable]
    public class MineCounter : IGameObserver
    {
        private Label mineCounterLabel;

        public MineCounter(Label mineCounterLabel)
        {
            this.mineCounterLabel = mineCounterLabel;
        }

        public void Update(string message)
        {
            if (message != "flagged")
                return;

            if (Game.Instance.GameInProgress == false && Game.Instance.Board != null)
            {
                int totalMines = Game.Instance.Board.TotalMines;
                mineCounterLabel.Text = totalMines.ToString().PadLeft(3, '0');
            }
            else if (Game.Instance.GameInProgress == true && Game.Instance.Board != null)
            {
                int flaggedCells = Game.Instance.Board.GetCells().Count(c => c.IsFlagged);
                int totalMines = Game.Instance.Board.TotalMines;
                mineCounterLabel.Text = (totalMines - flaggedCells).ToString().PadLeft(3, '0');
            }
            else
            {
                mineCounterLabel.Text = "0";
            }
        }
    }

}
