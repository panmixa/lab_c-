using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class StandardGame : Game
    {
        public StandardGame(int rating) : base(rating) { }


        public override void ParticipateIn(GameAccount gameAccount)
        {
            if (participants.Contains(gameAccount))
                return;
            participants.Add(gameAccount);
        }
        public override int CalculateRatingChange(bool hasWon)
        {
            return hasWon ? 10 : -10;
        }
    }
}
