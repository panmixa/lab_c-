using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal interface IGameService
    {
        public IEnumerable<Game> ReadGames();
        public IEnumerable<Game> ReadPlayerGamesByPlayerUsername(string username);

        public Game CreateGame(string gameType, int rating);
    }
}
