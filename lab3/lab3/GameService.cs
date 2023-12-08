using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class GameService
    {
        public IPlayerRepository playerRepository;
        public IGameRepository gameRepository;

        public GameService(IPlayerRepository playerRepo, IGameRepository gameRepo)
        {
            playerRepository = playerRepo;
            gameRepository = gameRepo;
        }

        public void CreateAccount(string userName, int initialRating)
        {
            Player newPlayer = new Player { UserName = userName, CurrentRating = initialRating };
            playerRepository.CreatePlayer(newPlayer);
        }

        public void RecordGameResult(string playerName, string opponentName, bool isWin, int ratingChange)
        {
            Player player = playerRepository.ReadAllPlayers().Find(p => p.UserName == playerName);
            if (player != null)
            {
                Game newGame = new Game { OpponentName = opponentName, IsWin = isWin, RatingChange = ratingChange };
                gameRepository.CreateGame(newGame);

                player.CurrentRating += ratingChange;
                playerRepository.UpdatePlayer(player);
            }
        }
    }
}
