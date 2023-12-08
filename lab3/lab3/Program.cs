using System;
using System.Collections.Generic;


namespace lab3
{
    interface IPlayerRepository
    {
        void CreatePlayer(Player player);
        Player ReadPlayerById(int playerId);
        List<Player> ReadAllPlayers();
        void UpdatePlayer(Player player);
        void DeletePlayer(int playerId);
    }

    interface IGameRepository
    {
        void CreateGame(Game game);
        Game ReadGameById(int gameId);
        List<Game> ReadAllGames();
        List<Game> ReadPlayerGamesByPlayerId(int playerId);
        void UpdateGame(Game game);
        void DeleteGame(int gameId);
    }

    class Program
    {
        static void Main()
        {
            DbContext dbContext = new DbContext();
            IPlayerRepository playerRepository = dbContext;
            IGameRepository gameRepository = dbContext;

            GameService gameService = new GameService(playerRepository, gameRepository);

            gameService.CreateAccount("User1", 1000);
            gameService.CreateAccount("User2", 1200);
            gameService.CreateAccount("User3", 1500);

            gameService.RecordGameResult("User1", "User2", true, 50);
            gameService.RecordGameResult("User1", "User3", false, -30);
            gameService.RecordGameResult("User1", "User4", true, 50);

            foreach (var player in playerRepository.ReadAllPlayers())
            {
                Console.WriteLine($"Гравець: {player.UserName}, Рейтинг: {player.CurrentRating}");
            }

            // Вивід результатів гри для конкретного гравця
            string playerName = "User1";
            Console.WriteLine($"Результати гри для гравця {playerName}:");
            foreach (var game in gameRepository.ReadPlayerGamesByPlayerId(playerRepository.ReadAllPlayers().Find(p => p.UserName == playerName).PlayerId))
            {
                Console.WriteLine($"Проти {game.OpponentName}, Результат: {(game.IsWin ? "перемога" : "поразка")}, Рейтинг: {game.RatingChange}");
            }

            Console.WriteLine("Всi iгри:");
            foreach (var game in gameRepository.ReadAllGames())
            {
                Console.WriteLine($"Гра з ID {game.GameId}, Проти {game.OpponentName}, Результат: {(game.IsWin ? "перемога" : "поразка")}, Рейтинг: {game.RatingChange}");
            }

            Console.ReadKey();
        }
    }
}