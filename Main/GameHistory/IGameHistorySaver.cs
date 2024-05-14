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
}
