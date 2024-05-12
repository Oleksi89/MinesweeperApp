using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Main;
using System.Text.Json;

namespace Main
{



    public partial class GameForm : Form, IGameObserver
    {
        private Game game;
        private BoardControl boardControl;
        private GameTimer gameTimer;
        private MineCounter mineCounter;
        private GameWonControl gameWonControl;
        private string settingsPath = "settings.dat";


        public GameForm()
        {
            InitializeComponent();
            
            game = Game.Instance;
            game.Initialize();
            
            game.RegisterObserver(this);
            gameTimer = new GameTimer(timerLabel);
            game.RegisterObserver(gameTimer);
            gameWonControl = new GameWonControl();
            mineCounter = new MineCounter(mineCounterLabel);
            game.RegisterObserver(mineCounter);
            this.Controls.Add(gameWonControl);
            gameWonControl.Dock = DockStyle.Fill;
            gameWonControl.Visible = false;
            LoadGameSettings(settingsPath);
        }

        public void Update(string message)
        {
            if (message == "game won")
            {

                gameWonControl.UpdateGameWonInfo(gameTimer.TimeElapsed, game.BestBeginnerTime, game.ClicksMade);
                gameWonControl.Visible = true;
                gameWonControl.BringToFront();
            }
            if (message == "game lost")
            {
                MessageBox.Show("You Lost!");
            }

            if (message == "game started")
            {
                if (boardControl != null)
                {
                    this.Controls.Remove(boardControl);
                }
                boardControl = new BoardControl(game.Board);
                this.Controls.Add(boardControl);
            }
            // playerInfoLabel.Text = $"{game.ClicksMade}";

            if (message == "regenerate board" && Game.Instance.Settings.FirstClickIsSafe)
            {
                boardControl.UpdateBoard();
            }

        }



    public void SaveGameSettings(GameSettings settings, string filePath)
    {

            string jsonString = JsonSerializer.Serialize(settings);
            File.WriteAllText(filePath, jsonString);
    }

        public void LoadGameSettings(string filePath)
        {
            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);
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
                    game.AddGameSetting(new SafeStart());
                }

                if (settings.ClickNumberOpensAdjacentCells)
                {
                    game.AddGameSetting(new SafeZone());
                }

                if (settings.ClickOnMineStartsDefuseCountdown)
                {
                    game.AddGameSetting(new Defuse());
                }

                if (settings.AllMinesFlaggedOpensRemainingCells)
                {
                    game.AddGameSetting(new OpenRemaining());
                }

                game.Settings = settings;                
            }
        }



    private void startGameButton_Click(object sender, EventArgs e)
        {
            string playerName = playerNameTextBox.Text;
            game.StartGame(playerName);
        }

        private void endGameButton_Click(object sender, EventArgs e)
        {
            game.EndGame();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            new LoginForm(game).ShowDialog();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            new GameSettingsForm(game).ShowDialog();
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            new PauseMenuForm(game).ShowDialog();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {

        }

        private void openRemainingCellsButton_Click(object sender, EventArgs e)
        {
            if (Game.Instance.Settings.AllMinesFlaggedOpensRemainingCells && Game.Instance.Board.TotalMines == Game.Instance.Board.GetCells().Cast<Cell>().Count(c => c.IsFlagged))
            {
                Game.Instance.Board.OpenRemainingCells();
            }
        }

        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveGameSettings(game.Settings, settingsPath);
        }
    }

}
