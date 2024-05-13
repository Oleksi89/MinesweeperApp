using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Main
{
    public class JsonGameHistoryLoader
    {
        public static List<GameHistoryEntry> Load(string filePath)
        {
            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<List<GameHistoryEntry>>(jsonString);
            }
            else
            {
                return new List<GameHistoryEntry>();
            }
        }
    }
}
