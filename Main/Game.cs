using Main.Properties;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Main
{
    public class Game
    {
        private static Game _instance;
        public static Game Instance => _instance ?? (_instance = new Game());
        private List<IGameObserver> observers = new List<IGameObserver>();
        private Board _board;
        public bool FirstClickIsSafe { get; set; }
        public bool ClickNumberOpensAdjacentCells { get; set; }
        public bool ClickOnMineStartsDefuseCountdown { get; set; }
        public bool AllMinesFlaggedOpensRemainingCells { get; set; }
        public double BestBeginnerTime = 3;

        private bool gameInProgress;
        public Board Board { get { return _board; }  }
        public bool GameInProgress { get { return gameInProgress; } }
        public bool FirstClickMade = false;
        public int ClicksMade = 0;
        public GameSettings Settings { get; set; }

        private Game() { }

        public void Initialize()
        {
            Settings = new GameSettings(new EasyDifficultyLevelStrategy());
        }

        private List<IGameSetting> gameSettings = new List<IGameSetting>();
        public List<IGameSetting> GameSettings { get { return gameSettings; } }
        public void AddGameSetting(IGameSetting gameSetting)
        {
            gameSettings.Add(gameSetting);
        }


        public void RegisterObserver(IGameObserver observer)
        {
            observers.Add(observer);
        }

        public void UnregisterObserver(IGameObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers(string message)
        {
            foreach (IGameObserver observer in observers)
            {
                observer.Update(message);
            }
        }

        public void StartGame(string playerName)
        {
            ClicksMade = 0;
            foreach (var gameSetting in gameSettings)
            {
                gameSetting.Apply(this);
            }
            _board = new Board(Settings.DifficultyLevelStrategy.GetDifficultyLevel().Width, Settings.DifficultyLevelStrategy.GetDifficultyLevel().Height);
            _board.GenerateBoard(Settings.DifficultyLevelStrategy);
            NotifyObservers("game started");
            gameInProgress = true;

        }

        public void GameLost()
        {
            Board.OpenRemainingCells();
            EndGame();
            NotifyObservers("game lost");           
            
        }
        public void GameWon()
        {
            EndGame();
            NotifyObservers("game won");
            
        }
            public void EndGame()
        {
            
            gameInProgress = false;
            //_board = null;
            NotifyObservers("game ended");
            
        }
        public void OpenNumberAdjacentCells(int x, int y)
        {
            Board.OpenNumberAdjacentCells( x, y);
        }
        public void GenerateNewBoardAndClick(int x, int y)
        {
            Board.ReGenerateBoard(Settings.DifficultyLevelStrategy, x, y);
            NotifyObservers("regenerate board");
            Board.GetCell(x, y).Click();
        }
    }


}
