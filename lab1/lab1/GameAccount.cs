using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class GameAccount
    {
        public string UserName { get; set; }
        public int CurrentRating { get; private set; }
        public int GamesCount { get; private set; }
        private List<Game> gameHistory;

        public GameAccount(string userName, int initialRating = 1000)
        {
            UserName = userName;
            CurrentRating = initialRating;
            GamesCount = 0;
            gameHistory = new List<Game>();
        }

        public void WinGame(string opponentName, int rating)
        {
            if (rating < 0)
            {
                throw new ArgumentException("Rating cannot be negative.");
            }

            GamesCount++;
            CurrentRating = Math.Max(1, CurrentRating + rating);
            gameHistory.Add(new Game(opponentName, true, rating));
        }

        public void LoseGame(string opponentName, int rating)
        {
            if (rating < 0)
            {
                throw new ArgumentException("Rating cannot be negative.");
            }

            GamesCount++;
            CurrentRating = Math.Max(1, CurrentRating - rating);
            gameHistory.Add(new Game(opponentName, false, rating));
        }

        public void GetStats()
        {
            Console.WriteLine($"Game history for {UserName}:");
            Console.WriteLine("Opponent\tResult\tRating\tGame Index");

            for (int i = 0; i < gameHistory.Count; i++)
            {
                Console.WriteLine($"{gameHistory[i].OpponentName}\t\t" +
                                  $"{(gameHistory[i].IsWin ? "Win" : "Lose")}\t" +
                                  $"{gameHistory[i].Rating}\t{i + 1}");
            }
        }
    }
}
