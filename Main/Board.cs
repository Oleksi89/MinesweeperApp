using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Main;

namespace Main
{
    public class Board
    {
        public int Width { get; }
        public int Height { get; }

        private Cell[,] cells;

        public int TotalMines
        {
            get
            {
                // Підраховуємо кількість мін на дошці
                return cells.Cast<Cell>().Count(c => c is MineCell);
            }
        }

        // private static Board _instance;
        // public static Board Instance => _instance ?? (_instance = new Board());
        public Board(int width, int height)
        {
            cells = new Cell[width, height];
            Width = width; Height = height;
        }

        public IEnumerable<Cell> GetCells()
        {           
            return cells.Cast<Cell>();
        }

        public Cell GetCell(int x, int y)
        {
            return cells[x, y];
        }

        public void GenerateBoard(IDifficultyLevelStrategy difficultyLevelStrategy)
        {
            DifficultyLevel difficultyLevel = difficultyLevelStrategy.GetDifficultyLevel();
            CellFactory cellFactory = new CellFactory();
            InitializeCells();
            PlaceMines(difficultyLevel);
            InsertNumberCells();

        }

        public void ReGenerateBoard(IDifficultyLevelStrategy difficultyLevelStrategy, int safeX, int safeY)
        {
            DifficultyLevel difficultyLevel = difficultyLevelStrategy.GetDifficultyLevel();
            CellFactory cellFactory = new CellFactory();
            InitializeCells();
            PlaceMines(difficultyLevel, safeX, safeY);
            InsertNumberCells();

        }

        public void InitializeCells()
        {
            CellFactory cellFactory = new CellFactory();

            // Initialize all cells as EmptyCell
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    cells[i, j] = cellFactory.CreateCell("Empty", i, j);
                }
            }
        }
        public void PlaceMines(DifficultyLevel difficultyLevel)
        {
            CellFactory cellFactory = new CellFactory();

            Random rand = new Random();
            for (int i = 0; i < difficultyLevel.Mines; i++)
            {
                int x, y;
                do
                {
                    x = rand.Next(Width);
                    y = rand.Next(Height);
                } while (cells[x, y] is MineCell);

                cells[x, y] = cellFactory.CreateCell("Mine", x, y);
            }
        }

        public void PlaceMines(DifficultyLevel difficultyLevel, int safeX, int safeY)
        {
            CellFactory cellFactory = new CellFactory();

            Random rand = new Random();
            for (int i = 0; i < difficultyLevel.Mines; i++)
            {
                int x, y;
                do
                {
                    x = rand.Next(Width);
                    y = rand.Next(Height);
                } while (cells[x, y] is MineCell || IsAdjacent(x, y, safeX, safeY));

                cells[x, y] = cellFactory.CreateCell("Mine", x, y);
            }
        }

        private bool IsAdjacent(int x1, int y1, int x2, int y2)
        {
            return Math.Abs(x1 - x2) <= 1 && Math.Abs(y1 - y2) <= 1;
        }

        public bool IsGameLost()
        {
            int mineCounter = 0;
            bool isLost = false;
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    if (cells[i, j] is MineCell && (cells[i, j].IsRevealed || cells[i, j].IsFlagged))
                    {
                        mineCounter++;
                        if (cells[i, j].IsRevealed)
                            isLost = true;
                    }
                       
        }
            }
            return mineCounter == TotalMines && isLost;
        }


        public bool IsGameWon()
        {
            int totalCells = Width * Height;
            int openCells = 0;
            int mines = 0;

            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    if (cells[i, j].IsRevealed)
                    {
                        openCells++;
                    }
                    if (cells[i, j] is MineCell && !cells[i, j].IsRevealed)
                    {
                        mines++;
                    }
                }
            }

            return mines == TotalMines && openCells + mines == totalCells;
        }

        public double GetCorrectlyOpenedCellsPercentage()
        {
            int totalCells = Width * Height;
            int corectlyOpenedCells = 0;

            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    if (cells[i, j].IsRevealed && cells[i, j] is not MineCell)
                    {
                        corectlyOpenedCells++;
                    }
                    else if (cells[i, j] is MineCell && cells[i, j].IsFlagged 
                        && !cells[i, j].IsRevealed)
                    {
                        corectlyOpenedCells++;
                    }
                }
            }

            return corectlyOpenedCells/(double)totalCells;
        }


        public void InsertNumberCells()
        {
            // Calculate adjacent mines and replace EmptyCell with NumberCell where needed
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    if (cells[i, j] is EmptyCell)
                    {
                        int adjacentMines = CountAdjacentMines(i, j);
                        if (adjacentMines > 0)
                        {
                            cells[i, j] = new NumberCell(i, j, adjacentMines);
                        }
                    }
                }
            }
        }



            private int CountAdjacentMines(int x, int y)
        {
            int count = 0;
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    int newX = x + i;
                    int newY = y + j;
                    if (newX >= 0 && newX < Width && newY >= 0 && newY < Height && cells[newX, newY] is MineCell)
                    {
                        count++;
                    }
                }
            }
            return count;
        }


        
        public void OpenAdjacentEmptyCells(Cell cell)
        {
            // Отримуємо координати клітини
            int x = cell.X;
            int y = cell.Y;

            // Перевіряємо всі сусідні клітини
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    int newX = x + i;
                    int newY = y + j;
                    // Переконуємося, що нові координати знаходяться в межах дошки
                    if (newX >= 0 && newX < Width && newY >= 0 && newY < Height)
                    {
                        Cell adjacentCell = cells[newX, newY];
                        // Якщо сусідня клітинка пуста не відкрита не помічена, відкриваємо її
                        if (adjacentCell is not MineCell && !adjacentCell.IsRevealed && !adjacentCell.IsFlagged)
                        {
                            //Game.Instance.Board
                            adjacentCell.Open();
                        }
                    }
                }
            }
        }

        public void OpenNumberAdjacentCells(int x, int y)
        {
            // Перевіряємо, чи клітина є NumberCell
            if (cells[x, y] is NumberCell numberCell)
            {
                // Отримуємо список сусідніх клітин
                List<Cell> adjacentCells = GetAdjacentCells(x, y);

                // Перевіряємо, чи кількість сусідніх клітин, позначених прапорцем, дорівнює значенню NumberCell
                if (adjacentCells.Count(cell => cell.IsFlagged) == numberCell.AdjacentMines)
                {
                    // Якщо це так, відкриваємо всі сусідні клітини
                    foreach (var cell in adjacentCells)
                    {
                        if(!cell.IsRevealed && !cell.IsFlagged)
                        cell.Click();
                    }
                }
            }
        }

        public List<Cell> GetAdjacentCells(int x, int y)
        {
            var adjacentCells = new List<Cell>();

            // Перевіряємо всі сусідні клітини
            for (int i = Math.Max(0, x - 1); i <= Math.Min(cells.GetLength(0) - 1, x + 1); i++)
            {
                for (int j = Math.Max(0, y - 1); j <= Math.Min(cells.GetLength(1) - 1, y + 1); j++)
                {
                    // Пропускаємо саму клітину
                    if (i == x && j == y)
                        continue;

                    adjacentCells.Add(cells[i, j]);
                }
            }

            return adjacentCells;
        }

        public void OpenRemainingMines()
        {
            
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    Cell cell = cells[i, j];
                    
                    if (!cell.IsRevealed && (cell is MineCell || (cell.IsFlagged && cell is not MineCell)))
                    {
                        cell.Open();
                    }
                }
            }
        }


        public void OpenRemainingCells()
        {
            // Перевіряємо всі клітини на дошці
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    Cell cell = cells[i, j];
                    // Якщо клітинка не відкрита , відкриваємо її
                    if (!cell.IsRevealed && !(cell.IsFlagged && cell is MineCell))
                    {
                        cell.Open();
                    }
                }
            }
            if (Game.Instance.Board.IsGameLost() && !Game.Instance.Settings.ClickOnMineStartsDefuseCountdown == true)
                Game.Instance.GameLost();
        }

    }

}
