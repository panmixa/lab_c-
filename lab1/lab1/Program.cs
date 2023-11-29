using System;
using System.Collections.Generic;

namespace lab1 { 

    class Program
    {
        static void Main()
        {
            GameAccount player1 = new GameAccount("Player1");
            GameAccount player2 = new GameAccount("Player2");

            // Simulate games
            player1.WinGame("Player2", 20);
            player2.LoseGame("Player1", 20);
            player1.LoseGame("Player2", 15);
            player2.WinGame("Player1", 15);

            // Display stats
            player1.GetStats();
            player2.GetStats();
        }
    }
}