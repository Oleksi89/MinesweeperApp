using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public abstract class Cell
    {
        public int X { get; set; }
        public int Y { get; set; }
        public bool IsRevealed { get; set; }
        public bool IsFlagged { get; set; }

        public Cell(int x, int y)
        {
            X = x;
            Y = y;
        }
        public event Action OnClick = delegate { };

        protected void RaiseOnClick()
        {
            OnClick?.Invoke();
        }
        public void Open()
        {
            IsRevealed = true;
            RaiseOnClick();
            if (Game.Instance.Board.IsGameWon())
                Game.Instance.GameWon();
            

            if (!IsFlagged && this is EmptyCell)
            {
                Game.Instance.Board.OpenAdjacentEmptyCells(this);
            }
        }
        public abstract void Click();
        public void RightClick()
        {
            // Перемикаємо стан прапорця
            if (!IsRevealed)
            {
                IsFlagged = !IsFlagged;
            }
            Game.Instance.NotifyObservers("flagged");
        }
        public void IsFirstClick()
        {
            if (Game.Instance.ClicksMade == 0)
            {
                Game.Instance.StartGame();
            }            
        }
    }
    public class EmptyCell : Cell
    {
        public EmptyCell(int x, int y) : base(x, y) { }
        public override void Click()
        {
            IsFirstClick();
            // Якщо клітинка пуста і не позначена прапорцем, відкриваємо її
            if (!IsFlagged && !IsRevealed)
            {
                Game.Instance.ClicksMade++;
                Open();

            }
        }   
    }

    public class MineCell : Cell
    {
        public MineCell(int x, int y) : base(x, y) { }
        public override void Click()
        {
            IsFirstClick();
            // Якщо клітинка з міною і не позначена прапорцем, вона вибухає
            if (!IsFlagged && !IsRevealed)
            {
                
                if (Game.Instance.Settings.FirstClickIsSafe && Game.Instance.ClicksMade == 0)
                {
                    
                    Game.Instance.GenerateNewBoardAndClick(X, Y);
                    
                }
                else
                {
                    Game.Instance.ClicksMade++;
                    Open();
                     if (!Game.Instance.Settings.ClickOnMineStartsDefuseCountdown == true)                                            
                        Game.Instance.GameLost();                        
                    
                    
                }          
            }
        }
    }

    public class NumberCell : Cell
    {
        public int AdjacentMines { get; set; }

        public NumberCell(int x, int y, int adjacentMines) : base(x, y)
        {
            AdjacentMines = adjacentMines;
        }

        public override void Click()
        {
            IsFirstClick();
            // Якщо клітинка з числом і не позначена прапорцем, відкриваємо її
            if (!IsFlagged)
            {
                if (Game.Instance.Settings.ClickNumberOpensAdjacentCells && IsRevealed)
                {
                    Game.Instance.OpenNumberAdjacentCells(X, Y);
                    Game.Instance.ClicksMade++;
                }
                else if (Game.Instance.Settings.FirstClickIsSafe && Game.Instance.ClicksMade == 0)
                {
                   
                    Game.Instance.GenerateNewBoardAndClick(X, Y);

                }
                else
                {
                    Open();
                    Game.Instance.ClicksMade++;

                }               
            }           
        }
    }



    public class CellFactory
    {
        public Cell CreateCell(string type, int x, int y)
        {
            switch (type)
            {
                case "Empty":
                    return new EmptyCell(x, y);
                case "Mine":
                    return new MineCell(x, y);
                default:
                    throw new ArgumentException("Invalid cell type");
            }
        }
    }

}
