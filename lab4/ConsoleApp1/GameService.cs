using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class GameService : IGameService
    {
        IGameRepository gameRepository;
        public GameService(IGameRepository gameRepository) 
        {
            this.gameRepository = gameRepository;
        }

        public IEnumerable<Game> ReadGames()
        {
            return gameRepository.Read();
        }

        public IEnumerable<Game> ReadPlayerGamesByPlayerUsername(string username) 
        {
            List<Game> participatedGames= (List<Game>)gameRepository.Read().Where(game => game.participants.Exists(player => player.Username == username));
            return participatedGames;
        }

        public Game CreateGame(string gameType, int rating)
        {
            Game game = GameFactory.CreateGame(gameType, rating);
            gameRepository.Create(game);
            return game;
        }
    }
}
