using Main.Forms;

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
            this.Visible = false;
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            new GameSettingsForm(_game).ShowDialog();
        }

        private void statisticsButton_Click(object sender, EventArgs e)
        {
            new StatisticsForm(_game).ShowDialog();
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            new InfoForm().ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            var form = this.FindForm();
            if (form != null)
            {
                form.Close();
            }
        }
    }
}
