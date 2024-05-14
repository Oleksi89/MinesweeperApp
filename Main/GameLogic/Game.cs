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
        private MineCounter mineCounter;

        private bool gameInProgress;
        private string gameResult;
        private IGameHistorySaver _gameHistorySaver;
        private ISimilarGamesStatistic _statisticCalculator;
        public Board Board { get { return _board; } }
        public bool GameInProgress { get { return gameInProgress; } }
        public int ClicksMade { get; private set; }
        public GameSettings Settings { get; set; }
        public readonly string settingsPath = "settings.dat";
        public readonly string gamesHistoryPath = "gamesHistory.dat";

        private Game() { }

        public void Initialize(Control timerLabel, Control mineCounterLabel)
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

        private void NotifyObservers(string message)
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
                DifficultyLevel = Settings.DifficultyLevel,
                FirstClickIsSafe = Settings.FirstClickIsSafe,
                ClickNumberOpensAdjacentCells = Settings.ClickNumberOpensAdjacentCells,
                ClickOnMineStartsDefuseCountdown = Settings.ClickOnMineDefuses,
                AllMinesFlaggedOpensRemainingCells = Settings.AllMinesFlaggedOpensRemainingCells,
                PercentageOfCorrectlyOpenedCells = (double)Board.GetCorrectlyOpenedCellsPercentage(),
                EndTime = DateTime.Now,
                Result = gameResult,
                ClicksMade = ClicksMade,
                GameTime = gameTimer.TimeElapsed
            };

            return historyEntry;
        }
        public GamesStatistic GetGameStatistics(GameHistoryEntry historyEntry)
        {
            return _statisticCalculator.Get(historyEntry, gamesHistoryPath);
        }

        public void PrepareGame()
        {
            ClicksMade = 0;
            gameResult = "none";
            gameInProgress = false;
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
            if (gameInProgress && gameResult == "none")
            {
                gameInProgress = false;
                NotifyObservers("game paused");
            }
        }
        public void ResumeGame()
        {
            if (!gameInProgress && gameResult == "none" && ClicksMade != 0)
            {
                gameInProgress = true;
                NotifyObservers("game resumed");
            }

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
            NotifyObservers("game ended");
            var entry = GetGameData();
            _gameHistorySaver.Save(entry, gamesHistoryPath);
        }

        public void SaveSettings()
        {
            Settings.Save(settingsPath);
        }

        public void LoadSettings()
        {
            Settings.Load(settingsPath, this);
        }

        public void IsGameWon()
        {
            if (Board.IsGameWon())
                GameWon();
        }

        public void IsGameLost()
        {
            if (Board.IsGameLost() && !Settings.ClickOnMineDefuses)
                GameLost();
        }

        public void IncrementClicksMade()
        {
            ClicksMade++;
        }

        public void OpenNumberAdjacentCells(int x, int y)
        {
            Board.OpenNumberAdjacentCells(x, y);
        }

        public void GenerateNewBoardAndClick(int x, int y)
        {
            Board.ReGenerateBoard(Settings.DifficultyLevelStrategy, x, y);
            NotifyObservers("regenerate board");
            Board.GetCell(x, y).Click();
        }

        public void CellFlagged()
        {
            NotifyObservers("flagged");
        }
    }
}
