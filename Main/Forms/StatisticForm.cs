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
    public partial class StatisticsForm : Form
    {
       // private Player player;

        public StatisticsForm()
        {
            InitializeComponent();
        }

        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            //gamesPlayedLabel.Text = player.Statistics.GamesPlayed.ToString();
            //gamesWonLabel.Text = player.Statistics.GamesWon.ToString();
            //gamesLostLabel.Text = player.Statistics.GamesLost.ToString();
        }
    }
}
