using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{

    class BaseRating : IRatingCalculationStrategy
    {
        public int CalculateRatingChange(bool isWin)
        {
            return isWin ? 50 : -30;
        }
    }

    class HalfRating : IRatingCalculationStrategy
    {
        public int CalculateRatingChange(bool isWin)
        {
            return isWin ? 50 : -15; 
        }
    }

    class WinningStreak : IRatingCalculationStrategy
    {
        private int consecutiveWins = 0;

        public int CalculateRatingChange(bool isWin)
        {
            if (isWin)
            {
                consecutiveWins++;
                return 50 + consecutiveWins * 10; 
            }
            else
            {
                consecutiveWins = 0; 
                return -30;
            }
        }
    }
}
