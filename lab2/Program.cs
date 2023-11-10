using System;
using System.Collections.Generic;


namespace first
{
    interface IRatingCalculationStrategy
    {
        int CalculateRatingChange(bool isWin);
    } 

    class Program
    {
        static void Main()
        {

            Game standardGame = GameFactory.CreateStandardGame();
            Game trainingGame = GameFactory.CreateTrainingGame();
            Game singlePlayerGame = GameFactory.CreateSinglePlayerGame();

            GameAccount player1 = new GameAccount("User1", 1000, new BaseRating());
            GameAccount player2 = new GameAccount("User2", 1200, new HalfRating());
            GameAccount player3 = new GameAccount("User3", 1500, new WinningStreak());

            player1.WinGame("User2", standardGame);
            player1.LoseGame("User3", standardGame);
            player1.WinGame("User4", standardGame);

            player2.WinGame("User1", trainingGame);
            player2.LoseGame("User3", trainingGame);

            player3.WinGame("AI", singlePlayerGame);
            player3.WinGame("AI", singlePlayerGame);
            player3.WinGame("AI", singlePlayerGame);

            player1.GetStats();
            player2.GetStats();
            player3.GetStats();

            Console.ReadKey();
        }
    }
}