﻿using Main.Controls;
using System.Data;

namespace Main
{



    public partial class GameForm : Form, IGameObserver
    {
        private Game game;
        private BoardControl boardControl;
        private GameWonControl gameWonControl;
        private PauseControl pauseControl;

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

            pauseControl = new PauseControl(game);
            this.Controls.Add(pauseControl);
            pauseControl.Dock = DockStyle.Fill;
            pauseControl.Visible = false;

            game.PrepareGame();
        }

        public void Update(string message)
        {
            switch (message)
            {
                case "game won":
                    var gameData = game.GetGameData();
                    var statistics = game.GetGameStatistics(gameData);
                    gameWonControl.UpdateGameWonInfo(gameData, statistics);
                    gameWonControl.Visible = true;
                    gameWonControl.BringToFront();
                    break;
                case "game lost":
                    MessageBox.Show("You Lost!");
                    break;
                case "game prepared":
                    if (boardControl != null)
                    {
                        BoardPanel.Controls.Remove(boardControl);
                    }
                    boardControl = new BoardControl(game.Board);
                    BoardPanel.Controls.Add(boardControl);
                    break;
                case "regenerate board":
                    boardControl.UpdateBoard();
                    break;
            }
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            game.PrepareGame();
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            game.PauseGame();
            pauseControl.Visible = true;
            pauseControl.BringToFront();
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

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (!pauseControl.Visible)
                {
                    game.PauseGame();
                    pauseControl.Visible = true;
                    pauseControl.BringToFront();
                }
                else if (pauseControl.Visible)
                {
                    game.ResumeGame();
                    pauseControl.Visible = false;
                }
            }
        }
    }

}
