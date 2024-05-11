using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            // Зчитуємо налаштування з game
            var settings = game.Settings;

            // Встановлюємо радіобатони відповідно до рівня складності
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

            // Встановлюємо чекбокси відповідно до налаштувань гри
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
            game.StartGame("");
            this.Close();
        }
    }

}
