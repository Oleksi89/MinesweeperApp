using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class DifficultyLevel
    {
        public int Width { get;}
        public int Height { get;}
        public int Mines { get;}

        public DifficultyLevel(int width, int height, int mines)
        {
            Width = width;
            Height = height;
            Mines = mines;
        }
    }

}
