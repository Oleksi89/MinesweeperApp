namespace Main
{
    public partial class GameSettingsForm : Form
    {
        private Game game;

        public GameSettingsForm(Game game)
        {
            InitializeComponent();
            this.game = game;
            LoadSettings();
        }

        private void LoadSettings()
        {
            // Load settings from game
            var settings = game.Settings;

            // Set radio buttons according to difficulty level
            if (settings.DifficultyLevelStrategy is EasyDifficultyLevelStrategy)
            {
                easyRadioButton.Checked = true;
            }
            else if (settings.DifficultyLevelStrategy is MediumDifficultyLevelStrategy)
            {
                mediumRadioButton.Checked = true;
            }
            else if (settings.DifficultyLevelStrategy is HardDifficultyLevelStrategy)
            {
                hardRadioButton.Checked = true;
            }

            // Set checkboxes according to game settings
            safeStartCheckBox.Checked = game.GameSettings.Any(gs => gs is SafeStart);
            safeZoneCheckBox.Checked = game.GameSettings.Any(gs => gs is SafeZone);
            defuseCheckBox.Checked = game.GameSettings.Any(gs => gs is Defuse);
            openRemainingCheckBox.Checked = game.GameSettings.Any(gs => gs is OpenRemaining);
        }



        private void saveButton_Click(object sender, EventArgs e)
        {
            IDifficultyLevelStrategy difficultyLevelStrategy;

            if (easyRadioButton.Checked)
            {
                difficultyLevelStrategy = new EasyDifficultyLevelStrategy();
            }
            else if (mediumRadioButton.Checked)
            {
                difficultyLevelStrategy = new MediumDifficultyLevelStrategy();
            }
            else //if(hardRadioButton.Checked)
            {
                difficultyLevelStrategy = new HardDifficultyLevelStrategy();
            }

            if (safeStartCheckBox.Checked)
            {
                game.AddGameSetting(new SafeStart());
            }
            else
                game.RemoveGameSetting<SafeStart>();

            if (safeZoneCheckBox.Checked)
            {
                game.AddGameSetting(new SafeZone());
            }
            else
                game.RemoveGameSetting<SafeZone>();

            if (defuseCheckBox.Checked)
            {
                game.AddGameSetting(new Defuse());
            }
            else
                game.RemoveGameSetting<Defuse>();

            if (openRemainingCheckBox.Checked)
            {
                game.AddGameSetting(new OpenRemaining());
            }
            else
                game.RemoveGameSetting<OpenRemaining>();


            game.Settings = new GameSettings(difficultyLevelStrategy);
            game.PrepareGame();
            this.Close();
        }
    }

}
