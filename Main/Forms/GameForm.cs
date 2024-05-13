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


        private GameWonControl gameWonControl;


        public GameForm()
        {
            InitializeComponent();

            game = Game.Instance;
            game.Initialize(timerLabel, mineCounterLabel);

            game.RegisterObserver(this);

            gameWonControl = new GameWonControl();

            this.Controls.Add(gameWonControl);
            gameWonControl.Dock = DockStyle.Fill;
            gameWonControl.Visible = false;
        }

        public void Update(string message)
        {
            if (message == "game won")
            {

                gameWonControl.UpdateGameWonInfo(/*gameTimer.TimeElapsed*/ 2, game.BestBeginnerTime, game.ClicksMade);
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
            game.SaveSettings();
        }

        private void statisticsButton_Click(object sender, EventArgs e)
        {
            new StatisticsForm(game).ShowDialog();
        }
    }

}
