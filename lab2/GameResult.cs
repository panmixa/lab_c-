using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    class GameResult
    {
        public string OpponentName { get; }
        public bool IsWin { get; }
        public int RatingChange { get; }

        public GameResult(string opponentName, bool isWin, int ratingChange)
        {
            OpponentName = opponentName;
            IsWin = isWin;
            RatingChange = ratingChange;
        }
    }
}
