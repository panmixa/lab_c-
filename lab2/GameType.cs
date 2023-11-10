using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    abstract class Game
    {
        public abstract int CalculateRatingChange(bool isWin);
    }
    class SinglePlayerGame : Game
    {
        public override int CalculateRatingChange(bool isWin)
        {
            return isWin ? 10 : -10; 
        }
    }

    class TrainingGame : Game
    {
        public override int CalculateRatingChange(bool isWin)
        {
            return 0; 
        }
    }

    class StandardGame : Game
    {
        public override int CalculateRatingChange(bool isWin)
        {
            return isWin ? 50 : -30;
        }
    }
}
