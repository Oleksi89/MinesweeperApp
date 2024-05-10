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
    public partial class GameWonControl : UserControl
    {
        public GameWonControl()
        {
            InitializeComponent();
        }

        public void UpdateGameWonInfo(double playingTime, double bestBeginnerTime, int numberOfClicks)
        {
            
            lblTitle.Text = "YOU WON!";
            lblSubtitle.Text = "Congratulations!";
            lblPlayingTime.Text = $"Playing time: {Math.Round(playingTime, 1)}";
            lblBestBeginnerTime.Text = $"Your best Beginner time: {Math.Round(bestBeginnerTime, 1)}";
            lblNumberOfClicks.Text = $"Number of clicks: {numberOfClicks}";
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Visible = false;
        }
    }
}
