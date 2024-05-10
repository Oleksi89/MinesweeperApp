using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class GameForm : Form
    {



        public GameForm()
        {
            InitializeComponent();


        }



        private void startGameButton_Click(object sender, EventArgs e)
        {

        }

        private void endGameButton_Click(object sender, EventArgs e)
        {
          
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

        }
    }

}
