using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Game
    {
        public int Rating { get; set; }
        public GameAccount Winner { get; set; }
        public List<GameAccount> participants { get; set; }

        public Game(int rating)
        {
            Rating = rating;
            participants = new List<GameAccount>();
        }
        public abstract void ParticipateIn(GameAccount gameAccount);
        public abstract int CalculateRatingChange(bool hasWon);
        public override string ToString()
        {
            return Rating + Winner?.ToString();
        }
    }
}
