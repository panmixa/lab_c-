using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class DBContext
    {
        public List<Game> games { get; }
        public List<GameAccount> accounts { get; }

        public DBContext() 
        {
            games = new List<Game>()
            {
                GameFactory.CreateGame("StandardGame", 2000),
                GameFactory.CreateGame("StandardGame", 1000),
                GameFactory.CreateGame("StandardGame", 1500)
            };
            accounts = new List<GameAccount>()
            {
                GameFactory.CreateGameAccount("StandardGameAccount", "Player1", 1600) ,
                GameFactory.CreateGameAccount("StandardGameAccount", "Player2", 1800),
                GameFactory.CreateGameAccount("StandardGameAccount", "Player3", 1700)
            };
        }

        public void CreateGame(Game game)
        {
            games.Add(game);
        }

        public void CreateAccount(GameAccount gameAccount)
        {
            accounts.Add(gameAccount);
        }

        public IEnumerable<Game> ReadGame()
        {
            return games;
        }

        public IEnumerable<GameAccount> ReadAccounts()
        {
            return accounts;
        }

        public void UpdateGame(Game gameToUpdate, Game game)
        {
            games.Insert(games.FindIndex(c => c == gameToUpdate),game);
            games.Remove(gameToUpdate);
        }

        public void UpdateAccount(GameAccount gameAccountToUpdate, GameAccount game)
        {
            accounts.Insert(accounts.FindIndex(c => c == gameAccountToUpdate), game);
            accounts.Remove(gameAccountToUpdate);
        }

        public void DeleteGame(Game game)
        {
            games.Remove(game);
        }

        public void DeleteAccount(GameAccount account)
        {
            accounts.Remove(account);
        }
    }
}
