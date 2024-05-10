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
    public partial class PauseMenuForm : Form
    {
        private Game game;

        public PauseMenuForm(Game game)
        {
            InitializeComponent();
            this.game = game;
        }

        private void resumeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveGameButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Saper Game|*.sg";
            saveFileDialog.Title = "Save Saper Game";
            saveFileDialog.ShowDialog();

            /*
            if (saveFileDialog.FileName != "")
            {
                game.SaveGame(saveFileDialog.FileName);
            }
            */
        }

        private void loadGameButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Saper Game|*.sg";
            openFileDialog.Title = "Load Saper Game";
            openFileDialog.ShowDialog();

            if (openFileDialog.FileName != "")
            {
                // game.LoadGame(openFileDialog.FileName);
            }
        }

        private void exitToMainMenuButton_Click(object sender, EventArgs e)
        {
            game.EndGame();
            this.Close();
        }
    }

}
