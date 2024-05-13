using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.GameHistory
{
    public class GamesStatistic
    {
        public double BestTime { get; set; }
        public double AverageTime { get; set; }
        public int LeastClicks { get; set; }
        public double AverageClicks { get; set; }
    }
    public interface ISimilarGamesStatistic
    {
        GamesStatistic Get(GameHistoryEntry historyEntry, string filePath);
    }
    public class JsonSimilarGamesStatistic : ISimilarGamesStatistic
    {
        public GamesStatistic Get(GameHistoryEntry historyEntry, string filePath)
        {
            var gameHistory = JsonGameHistoryLoader.Load(filePath);
            var similarGames = gameHistory.Where(game => game.DifficultyLevel == historyEntry.DifficultyLevel && game.Result == historyEntry.Result).ToList();
            if (similarGames.Any())
            {
                return new GamesStatistic
                {
                    BestTime = similarGames.Min(game => game.GameTime),
                    AverageTime = similarGames.Average(game => game.GameTime),
                    LeastClicks = similarGames.Min(game => game.ClicksMade),
                    AverageClicks = similarGames.Average(game => game.ClicksMade)
                };
            }
            else
            {
                return new GamesStatistic();
            }
        }
    }
}
