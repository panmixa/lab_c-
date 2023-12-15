using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class GameAccount
    {
        public string Username { get; set; }
        public int Rating { get; set; }
        public int TotalGamesPlayed { get; set; }
        public int TotalGamesWon { get; set; }

        public GameAccount(string username, int rating)
        {
            Username = username;
            Rating = rating;
            TotalGamesPlayed = 0;
            TotalGamesWon = 0;
        }

        public void WinGame(Game game)
        {
            Rating = CalculateNewRating(game, true);
            TotalGamesPlayed++;
            TotalGamesWon++;
        }

        public void LoseGame(Game game)
        {
            Rating = CalculateNewRating(game, false);
            TotalGamesPlayed++;
        }

        public abstract int CalculateNewRating(Game game, bool hasWon);
        public abstract string GetStats();
        public override string ToString()
        {
            return Username;
        }
    }
}
