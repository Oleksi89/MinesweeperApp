using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class DifficultyLevel
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int Mines { get; set; }

        public DifficultyLevel(int width, int height, int mines)
        {
            Width = width;
            Height = height;
            Mines = mines;
        }
    }

}
