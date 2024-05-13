using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Main
{
    public interface IGameHistorySaver
    {
        void Save(GameHistoryEntry historyEntry, string filePath);
    }

    public class JsonGameHistorySaver : IGameHistorySaver
    {
        public void Save(GameHistoryEntry historyEntry, string filePath)
        {

            List<GameHistoryEntry> history;
            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);
                history = JsonSerializer.Deserialize<List<GameHistoryEntry>>(jsonString);
            }
            else
            {
                history = new List<GameHistoryEntry>();
            }

            history.Add(historyEntry);

            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            string jsonHistoryString = JsonSerializer.Serialize(history, options);
            File.WriteAllText(filePath, jsonHistoryString);
        }
    }
}
