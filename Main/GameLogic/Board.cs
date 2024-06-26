﻿namespace Main
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
                return cells.Cast<Cell>().Count(c => c is MineCell);
            }
        }

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
            InitializeCells();
            PlaceMines(difficultyLevel);
            InsertNumberCells();

        }

        public void ReGenerateBoard(IDifficultyLevelStrategy difficultyLevelStrategy, int safeX, int safeY)
        {
            DifficultyLevel difficultyLevel = difficultyLevelStrategy.GetDifficultyLevel();;
            InitializeCells();
            PlaceMines(difficultyLevel, safeX, safeY);
            InsertNumberCells();

        }

        public void InitializeCells()
        {

            // Initialize all cells as EmptyCell
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    cells[i, j] = CellFactory.CreateCell("Empty", i, j);
                }
            }
        }
        public void PlaceMines(DifficultyLevel difficultyLevel)
        {

            Random rand = new Random();
            for (int i = 0; i < difficultyLevel.Mines; i++)
            {
                int x, y;
                do
                {
                    x = rand.Next(Width);
                    y = rand.Next(Height);
                } while (cells[x, y] is MineCell);

                cells[x, y] = CellFactory.CreateCell("Mine", x, y);
            }
        }

        public void PlaceMines(DifficultyLevel difficultyLevel, int safeX, int safeY)
        {

            Random rand = new Random();
            for (int i = 0; i < difficultyLevel.Mines; i++)
            {
                int x, y;
                do
                {
                    x = rand.Next(Width);
                    y = rand.Next(Height);
                } while (cells[x, y] is MineCell || IsAdjacent(x, y, safeX, safeY));

                cells[x, y] = CellFactory.CreateCell("Mine", x, y);
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
                    else if (cells[i, j] is MineCell && !cells[i, j].IsRevealed)
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
                            cells[i, j] = CellFactory.CreateCell("Number",i, j, adjacentMines);
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



        public void OpenEmptyAdjacentCells(Cell cell)
        {
            // Get cell coordinates
            int x = cell.X;
            int y = cell.Y;

            // Check all adjacent cells
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    int newX = x + i;
                    int newY = y + j;
                    // Make sure the new coordinates are within the board
                    if (newX >= 0 && newX < Width && newY >= 0 && newY < Height)
                    {
                        Cell adjacentCell = cells[newX, newY];
                        // If the adjacent cell is not a mine, not open, not flagged, open it
                        if (adjacentCell is not MineCell && !adjacentCell.IsRevealed && !adjacentCell.IsFlagged)
                        {
                            adjacentCell.Open();
                        }
                    }
                }
            }
        }

        public void OpenNumberAdjacentCells(int x, int y)
        {
            // Check if the cell is a NumberCell
            if (cells[x, y] is NumberCell numberCell)
            {
                // Get a list of adjacent cells
                List<Cell> adjacentCells = GetAdjacentCells(x, y);

                // Check if the number of adjacent cells flagged equals the value of NumberCell
                if (adjacentCells.Count(cell => cell.IsFlagged) == numberCell.AdjacentMines)
                {
                    // If so, open all adjacent cells
                    foreach (var cell in adjacentCells)
                    {
                        if (!cell.IsRevealed && !cell.IsFlagged)
                            cell.Click();
                    }
                }
            }
        }

        public List<Cell> GetAdjacentCells(int x, int y)
        {
            var adjacentCells = new List<Cell>();

            // Check all adjacent cells
            for (int i = Math.Max(0, x - 1); i <= Math.Min(cells.GetLength(0) - 1, x + 1); i++)
            {
                for (int j = Math.Max(0, y - 1); j <= Math.Min(cells.GetLength(1) - 1, y + 1); j++)
                {
                    // Skip the cell itself
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
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    Cell cell = cells[i, j];
                    if (!cell.IsRevealed && !(cell.IsFlagged && cell is MineCell))
                    {
                        cell.Open();
                    }
                }
            }
                Game.Instance.IsGameLost();
        }

    }

}
