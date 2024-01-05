using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class UserDatabase : IEnumerable<User>
    {
        private List<User> users;
        private List<GameResult> gameResults;

        public UserDatabase()
        {
            users = new List<User>();
            gameResults = new List<GameResult>();
        }

        public void AddUser(User user)
        {
            users.Add(user);
        }

        public User GetUserByUsername(string username)
        {
            return users.Find(u => u.Username == username);
        }

        public void UpdateRating(User winner, User loser, bool isDraw)
        {
            if (isDraw)
            {
                winner.Rating += 1;
                loser.Rating += 1;
            }
            else
            {
                winner.Rating += 3;
            }
        }

        public void AddGameResult(GameResult result)
        {
            gameResults.Add(result);
        }

        public void DisplayGameHistory()
        {
            Console.WriteLine("Game History:");
            foreach (var result in gameResults)
            {
                string outcome = result.IsDraw ? "Draw" : $"{result.Winner.Username} wins against {result.Loser.Username}";
                Console.WriteLine(outcome);
            }
        }

        public IEnumerator<User> GetEnumerator()
        {
            return users.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
