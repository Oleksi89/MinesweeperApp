﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public interface ISimilarGamesStatistic
    {
        GamesStatistic Get(GameHistoryEntry historyEntry, string filePath);
    }
}
