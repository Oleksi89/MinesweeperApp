using Main;
using Main.Properties;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Main
{

    public class Game
    {
        private static Game _instance;
        public static Game Instance => _instance ?? (_instance = new Game());
        private List<IGameObserver> observers = new List<IGameObserver>();

        public Board _board;

        public double BestBeginnerTime = 3;

        private bool gameInProgress;
        public Board Board { get { return _board; }}
        public bool GameInProgress { get { return gameInProgress; } }
        public bool FirstClickMade = false;
        public int ClicksMade = 0;
        public GameSettings Settings { get; set; }
        public readonly string settingsPath = "settings.dat";

        private Game() { }

        public void Initialize()
        {
            Settings = new GameSettings(new EasyDifficultyLevelStrategy());
            LoadSettings();
        }

        private List<IGameSetting> gameSettings = new List<IGameSetting>();
        public List<IGameSetting> GameSettings { get { return gameSettings; } }
        public void AddGameSetting(IGameSetting gameSetting)
        {
            gameSettings.Add(gameSetting);
        }
        public void RemoveGameSetting<T>() where T : IGameSetting
        {
            var settingToRemove = gameSettings.OfType<T>().FirstOrDefault();
            if (settingToRemove != null)
            {
                gameSettings.Remove(settingToRemove);
            }
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
            ClearSettings();

            foreach (var gameSetting in gameSettings)
            {
                gameSetting.Apply(this);
            }
            _board = new Board(Settings.DifficultyLevelStrategy.GetDifficultyLevel().Width, Settings.DifficultyLevelStrategy.GetDifficultyLevel().Height);
            _board.GenerateBoard(Settings.DifficultyLevelStrategy);
            NotifyObservers("game started");
            gameInProgress = true;

        }

        public void ClearSettings()
        {
            Settings.FirstClickIsSafe = false;
            Settings.ClickNumberOpensAdjacentCells = false;
            Settings.ClickOnMineStartsDefuseCountdown = false;
            Settings.AllMinesFlaggedOpensRemainingCells = false;
        }

        public void GameLost()
        {
            Board.OpenRemainingMines();
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

        public void SaveSettings()
        {

            string jsonString = JsonSerializer.Serialize(Settings);
            File.WriteAllText(settingsPath, jsonString);
        }

        public void LoadSettings()
        {
            if (File.Exists(settingsPath))
            {
                string jsonString = File.ReadAllText(settingsPath);
                GameSettings settings = JsonSerializer.Deserialize<GameSettings>(jsonString);

                switch (settings.DifficultyLevel)
                {
                    case "Easy":
                        settings.DifficultyLevelStrategy = new EasyDifficultyLevelStrategy();
                        break;
                    case "Medium":
                        settings.DifficultyLevelStrategy = new MediumDifficultyLevelStrategy();
                        break;
                    case "Hard":
                        settings.DifficultyLevelStrategy = new HardDifficultyLevelStrategy();
                        break;
                }

                if (settings.FirstClickIsSafe)
                {
                    AddGameSetting(new SafeStart());
                }

                if (settings.ClickNumberOpensAdjacentCells)
                {
                    AddGameSetting(new SafeZone());
                }

                if (settings.ClickOnMineStartsDefuseCountdown)
                {
                    AddGameSetting(new Defuse());
                }

                if (settings.AllMinesFlaggedOpensRemainingCells)
                {
                    AddGameSetting(new OpenRemaining());
                }

                Settings = settings;
            }
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
