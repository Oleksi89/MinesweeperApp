using Main.GameHistory;
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

        public void UpdateGameWonInfo(GameHistoryEntry currentGame, GamesStatistic statistics)
        {
            lblTitle.Text = "YOU WON!";
            lblSubtitle.Text = "Congratulations!";
            lblPlayingTime.Text = $"Playing time :   {Math.Round(currentGame.GameTime, 1)}";
            lblStatisticsTime.Text = $"Your  {currentGame.DifficultyLevel}  mode      Best time : {Math.Round(statistics.BestTime, 1)}   Average:  {Math.Round(statistics.AverageTime, 1)}";
            lblNumberOfClicks.Text = $"Number  of  clicks:  {currentGame.ClicksMade}";
            lblStatisticsClicks.Text = $"Your  {currentGame.DifficultyLevel}  mode       Best  clicks  result : {statistics.LeastClicks}    Average:  {Math.Round(statistics.AverageClicks, 1)}";
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Visible = false;
        }
    }
}
