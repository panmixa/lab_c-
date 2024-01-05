using System;
using System.Collections;
using System.Collections.Generic;


namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            UserDatabase userDatabase = new UserDatabase();

            do
            {
                string username1 = UserInterface.GetUsernameFromUser();
                string username2 = UserInterface.GetUsernameFromUser();

                User player1 = new User(username1, 'X');
                User player2 = new User(username2, 'O');

                userDatabase.AddUser(player1);
                userDatabase.AddUser(player2);

                List<User> players = new List<User> { player1, player2 };

                TicTacToeGame game = new TicTacToeGame(players);
                game.StartGame(userDatabase);

                userDatabase.DisplayGameHistory();

                foreach (var user in userDatabase)
                {
                    Console.WriteLine($"{user.Username}'s rating: {user.Rating}");
                }

                Console.Write("Do you want to play again? (yes/no): ");
            } while (Console.ReadLine().Equals("yes", StringComparison.OrdinalIgnoreCase));
        }
    }
}
