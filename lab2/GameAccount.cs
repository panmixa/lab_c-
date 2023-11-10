using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    class GameAccount
    {
        public string UserName { get; private set; }
        public int CurrentRating { get; private set; }
        public int GamesCount { get; private set; }
        private List<GameResult> gameHistory;
        private IRatingCalculationStrategy ratingCalculationStrategy;

        public GameAccount(string userName, int initialRating, IRatingCalculationStrategy strategy)
        {
            UserName = userName;
            if (initialRating < 1)
            {
                throw new ArgumentException("Рейтинг не може бути менше 1.");
            }
            CurrentRating = initialRating;
            GamesCount = 0;
            gameHistory = new List<GameResult>();
            ratingCalculationStrategy = strategy;
        }

        public void WinGame(string opponentName, Game game)
        {
            int ratingChange = game.CalculateRatingChange(true);
            CurrentRating += ratingChange;
            GamesCount++;
            gameHistory.Add(new GameResult(opponentName, true, ratingChange));
        }

        public void LoseGame(string opponentName, Game game)
        {
            int ratingChange = game.CalculateRatingChange(false);
            if (CurrentRating - ratingChange < 1)
            {
                CurrentRating = 1;
            }
            else
            {
                CurrentRating -= ratingChange;
            }
            GamesCount++;
            gameHistory.Add(new GameResult(opponentName, false, ratingChange));
        }

        public void GetStats()
        {
            Console.WriteLine($"Статистика для користувача {UserName} (Страта: {ratingCalculationStrategy.GetType().Name}):");
            for (int i = 0; i < gameHistory.Count; i++)
            {
                string result = gameHistory[i].IsWin ? "перемога" : "поразка";
                Console.WriteLine($"Гра {i + 1}: Проти {gameHistory[i].OpponentName}, Результат: {result}, Рейтинг: {gameHistory[i].RatingChange}");
            }
        }
    }
}
