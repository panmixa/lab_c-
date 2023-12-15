using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class StandardGameAccount : GameAccount
    {
        public StandardGameAccount(string username, int rating) : base(username, rating) { }

        public override int CalculateNewRating(Game game, bool hasWon)
        {
            return Rating + game.CalculateRatingChange(hasWon);
        }

        public override string GetStats()
        {
            return $"Username: {Username}, Rating: {Rating}, Total Games Played: {TotalGamesPlayed}, Total Games Won: {TotalGamesWon}";
        }
    }
}
