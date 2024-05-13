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

                var gameData = game.GetGameData();
                var statistics = game.GetGameStatistics(gameData);
                gameWonControl.UpdateGameWonInfo(gameData, statistics);
                gameWonControl.Visible = true;
                gameWonControl.BringToFront();
            }
            if (message == "game lost")
            {
                MessageBox.Show("You Lost!");
            }

            if (message == "game prepared")
            {
                if (boardControl != null)
                {
                    BoardPanel.Controls.Remove(boardControl);
                }
                boardControl = new BoardControl(game.Board);
                BoardPanel.Controls.Add(boardControl);
            }
            // playerInfoLabel.Text = $"{game.ClicksMade}";

            if (message == "regenerate board" && Game.Instance.Settings.FirstClickIsSafe)
            {
                boardControl.UpdateBoard();
            }

        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            game.PrepareGame();
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

        private void BoardPanel_Resize(object sender, EventArgs e)
        {
            BoardPanel.Left = (this.ClientSize.Width - BoardPanel.Width) / 2;
        }

        private void mineCounterLabel_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(mineCounterLabel.Text, out int number) && number == 0)
                mineCounterLabel.ForeColor = Color.Cyan;
            else mineCounterLabel.ForeColor = Color.Black;
        }
    }

}
