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
            game.Settings = new GameSettings(difficultyLevelStrategy);
            this.Close();
        }
    }

}
