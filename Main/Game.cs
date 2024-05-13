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
using Main.GameHistory;

namespace Main
{

    public class Game
    {
        private static Game _instance;
        public static Game Instance => _instance ?? (_instance = new Game());
        private List<IGameObserver> observers = new List<IGameObserver>();

        private Board _board;
        private GameTimer gameTimer;
        public GameTimer GameTimer { get { return gameTimer; } }
        private MineCounter mineCounter;

        private bool gameInProgress;
        private string gameResult;
        private IGameHistorySaver _gameHistorySaver;
        private ISimilarGamesStatistic _statisticCalculator;
        public Board Board { get { return _board; }}
        public bool GameInProgress { get { return gameInProgress; } }
        public int ClicksMade = 0;
        public GameSettings Settings { get; set; }
        public readonly string settingsPath = "settings.dat";
        public readonly string gameHistoryPath = "gameHistory.dat";

        private Game() { }

        public void Initialize(Label timerLabel, Label mineCounterLabel)
        {
            gameTimer = new GameTimer(timerLabel);
            RegisterObserver(gameTimer);

            mineCounter = new MineCounter(mineCounterLabel);
            RegisterObserver(mineCounter);

            Settings = new GameSettings(new EasyDifficultyLevelStrategy());
            LoadSettings();

            _gameHistorySaver = new JsonGameHistorySaver();
            _statisticCalculator = new JsonSimilarGamesStatistic();
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

        public GameHistoryEntry GetGameData()
        {
            var historyEntry = new GameHistoryEntry
            {
                DifficultyLevel = this.Settings.DifficultyLevel,
                FirstClickIsSafe = this.Settings.FirstClickIsSafe,
                ClickNumberOpensAdjacentCells = this.Settings.ClickNumberOpensAdjacentCells,
                ClickOnMineStartsDefuseCountdown = this.Settings.ClickOnMineStartsDefuseCountdown,
                AllMinesFlaggedOpensRemainingCells = this.Settings.AllMinesFlaggedOpensRemainingCells,
                PercentageOfCorrectlyOpenedCells = (double)Board.GetCorrectlyOpenedCellsPercentage(),
                EndTime = DateTime.Now,
                Result = this.gameResult,
                ClicksMade = this.ClicksMade,
                GameTime = gameTimer.TimeElapsed
            };

            return historyEntry;
        }
        public GamesStatistic GetGameStatistics(GameHistoryEntry historyEntry)
        {
            return _statisticCalculator.Get(historyEntry, gameHistoryPath);
        }

        public void PrepareGame()
        {
            ClicksMade = 0;
            gameResult = "none";
            ClearSettings();

            foreach (var gameSetting in gameSettings)
            {
                gameSetting.Apply(this);
            }
            _board = new Board(Settings.DifficultyLevelStrategy.GetDifficultyLevel().Width, Settings.DifficultyLevelStrategy.GetDifficultyLevel().Height);
            _board.GenerateBoard(Settings.DifficultyLevelStrategy);
            NotifyObservers("game prepared");
            
        }

        public void StartGame()
        {
            
            NotifyObservers("game started");
            gameInProgress = true;

        }

        public void PauseGame()
        {
            gameInProgress = false;
            NotifyObservers("game paused");
        }
        public void ResumeGame()
        {
            gameInProgress = true;
            NotifyObservers("game resumed");
        }

        public void ClearSettings()
        {
            Settings.ClearSettings();
        }

        public void GameLost()
        {
            Board.OpenRemainingMines();
            
            gameResult = "Lost";
            EndGame();
            NotifyObservers("game lost");           
            
        }
        public void GameWon()
        {
            
            gameResult = "Won";
            EndGame();
            NotifyObservers("game won");
            
        }
            public void EndGame()
        {
            
            gameInProgress = false;
            //_board = null;
            NotifyObservers("game ended");
            var entry = GetGameData();
            _gameHistorySaver.Save(entry, gameHistoryPath);
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
