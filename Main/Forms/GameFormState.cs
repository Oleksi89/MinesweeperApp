using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    [Serializable]
    public class GameFormState
    {
        public Game game;
        public Board board;
        public GameTimer gameTimer;
        public MineCounter mineCounter;
    }

    [Serializable]
    public class GameFormState1
    {
        public int game = 23;
        public string games = "vava";
        public double dod = 1.334434;
    }
}
