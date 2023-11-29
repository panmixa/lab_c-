using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Game
    {
        public string OpponentName { get; }
        public bool IsWin { get; }
        public int Rating { get; }

        private static int nextGameId = 1;
        public int GameIndex { get; }

        public Game(string opponentName, bool isWin, int rating)
        {
            OpponentName = opponentName;
            IsWin = isWin;
            Rating = rating;
            GameIndex = nextGameId++;
        }
    }
}
