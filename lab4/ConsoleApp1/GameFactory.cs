using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class GameFactory
    {
        public static Game CreateGame(string gameType, int rating)
        {
            switch (gameType)
            {
                case "StandardGame":
                    return new StandardGame(rating);
                default:
                    throw new ArgumentException("Invalid game type.");
            }
        }

        public static GameAccount CreateGameAccount(string accountType, string username, int rating)
        {
            switch (accountType)
            {
                case "StandardGameAccount":
                    return new StandardGameAccount(username, rating);
                default:
                    throw new ArgumentException("Invalid game account type.");
            }
        }
    }
}
