using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.Controls
{
    public partial class PauseControl : UserControl
    {
        private Game _game;

        public PauseControl(Game game)
        {
            InitializeComponent();
            _game = game;
        }

        private void resumeButton_Click(object sender, EventArgs e)
        {
            _game.ResumeGame(); 
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {

        }

        private void statisticsButton_Click(object sender, EventArgs e)
        {

        }

        private void infoButton_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {

        }
    }
}
