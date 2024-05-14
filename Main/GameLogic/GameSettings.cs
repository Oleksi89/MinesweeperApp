using Main.Properties;
using System.Text.Json.Serialization;
using System.Text.Json;
namespace Main
{

    public class GameSettings
    {
        public string DifficultyLevel { get; set; }

        [JsonIgnore]
        public IDifficultyLevelStrategy DifficultyLevelStrategy { get; set; }

        public bool FirstClickIsSafe { get; set; }
        public bool ClickNumberOpensAdjacentCells { get; set; }
        public bool ClickOnMineDefuses { get; set; }
        public bool AllMinesFlaggedOpensRemainingCells { get; set; }

        public GameSettings()
        {
            switch (DifficultyLevel)
            {
                case "Easy":
                    DifficultyLevelStrategy = new EasyDifficultyLevelStrategy();
                    break;
                case "Medium":
                    DifficultyLevelStrategy = new MediumDifficultyLevelStrategy();
                    break;
                case "Hard":
                    DifficultyLevelStrategy = new HardDifficultyLevelStrategy();
                    break;
            }
        }

        public GameSettings(IDifficultyLevelStrategy difficultyLevelStrategy)
        {
            DifficultyLevelStrategy = difficultyLevelStrategy;
            DifficultyLevel = difficultyLevelStrategy.GetType().Name.Replace("DifficultyLevelStrategy", "");
        }

        public void ClearSettings()
        {
            FirstClickIsSafe = false;
            ClickNumberOpensAdjacentCells = false;
            ClickOnMineDefuses = false;
            AllMinesFlaggedOpensRemainingCells = false;
        }

        public void Save(string settingsPath)
        {
            string jsonString = JsonSerializer.Serialize(this);
            File.WriteAllText(settingsPath, jsonString);
        }

        public void Load(string settingsPath, Game game)
        {
            if (File.Exists(settingsPath))
            {
                string jsonString = File.ReadAllText(settingsPath);
                GameSettings settings = JsonSerializer.Deserialize<GameSettings>(jsonString);

                switch (settings.DifficultyLevel)
                {
                    case "Easy":
                        settings.DifficultyLevelStrategy = new EasyDifficultyLevelStrategy();
                        break;
                    case "Medium":
                        settings.DifficultyLevelStrategy = new MediumDifficultyLevelStrategy();
                        break;
                    case "Hard":
                        settings.DifficultyLevelStrategy = new HardDifficultyLevelStrategy();
                        break;
                }

                if (settings.FirstClickIsSafe)
                {
                    game.AddGameSetting(new SafeStart());
                }

                if (settings.ClickNumberOpensAdjacentCells)
                {
                    game.AddGameSetting(new SafeZone());
                }

                if (settings.ClickOnMineDefuses)
                {
                    game.AddGameSetting(new Defuse());
                }

                if (settings.AllMinesFlaggedOpensRemainingCells)
                {
                    game.AddGameSetting(new OpenRemaining());
                }
                this.DifficultyLevel = settings.DifficultyLevel;
                this.DifficultyLevelStrategy = settings.DifficultyLevelStrategy;
            }
        }
    }

}
