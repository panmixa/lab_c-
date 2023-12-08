using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class DbContext : IPlayerRepository, IGameRepository
    {
        public List<Player> players;
        public List<Game> games;

        public DbContext()
        {
            players = new List<Player>();
            games = new List<Game>();
        }

        public void CreatePlayer(Player player)
        {
            players.Add(player);
        }

        public Player ReadPlayerById(int playerId)
        {
            return players.FirstOrDefault(p => p.PlayerId == playerId);
        }

        public List<Player> ReadAllPlayers()
        {
            return players;
        }

        public void UpdatePlayer(Player player)
        {
            Player existingPlayer = ReadPlayerById(player.PlayerId);
            if (existingPlayer != null)
            {
                existingPlayer.UserName = player.UserName;
                existingPlayer.CurrentRating = player.CurrentRating;
            }
        }

        public void DeletePlayer(int playerId)
        {
            Player player = ReadPlayerById(playerId);
            if (player != null)
            {
                players.Remove(player);
            }
        }

        public void CreateGame(Game game)
        {
            games.Add(game);
        }

        public Game ReadGameById(int gameId)
        {
            return games.FirstOrDefault(g => g.GameId == gameId);
        }

        public List<Game> ReadAllGames()
        {
            return games;
        }

        public List<Game> ReadPlayerGamesByPlayerId(int playerId)
        {
            return games.Where(g => g.PlayerId == playerId).ToList();
        }

        public void UpdateGame(Game game)
        {
            Game existingGame = ReadGameById(game.GameId);
            if (existingGame != null)
            {
                existingGame.OpponentName = game.OpponentName;
                existingGame.IsWin = game.IsWin;
                existingGame.RatingChange = game.RatingChange;
            }
        }

        public void DeleteGame(int gameId)
        {
            Game game = ReadGameById(gameId);
            if (game != null)
            {
                games.Remove(game);
            }
        }
    }
}
