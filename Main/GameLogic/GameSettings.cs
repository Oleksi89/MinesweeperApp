using System.Text.Json.Serialization;

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
    }

}
