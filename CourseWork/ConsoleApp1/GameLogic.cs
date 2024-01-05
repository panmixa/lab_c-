using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class TicTacToeGame
    {
        private char[,] grid;
        private int currentPlayerIndex;
        private List<User> players;

        public TicTacToeGame(List<User> players)
        {
            if (players.Count != 2)
            {
                throw new ArgumentException("The game requires exactly two players.");
            }

            this.players = players;
            grid = new char[3, 3];
            currentPlayerIndex = 0;
        }

        public void StartGame(UserDatabase userDatabase)
        {
            while (true)
            {
                PrintGrid();
                Console.WriteLine($"{players[currentPlayerIndex].Username}'s turn:");

                int x, y;
                do
                {
                    Console.Write("Enter X coordinate: ");
                    x = int.Parse(Console.ReadLine());
                    Console.Write("Enter Y coordinate: ");
                    y = int.Parse(Console.ReadLine());
                } while (!IsValidMove(x, y));

                grid[x, y] = players[currentPlayerIndex].Symbol;

                if (IsWin(players[currentPlayerIndex].Symbol))
                {
                    User winner = players[currentPlayerIndex];
                    User loser = players[1 - currentPlayerIndex];
                    Console.WriteLine($"{winner.Username} wins!");

                    userDatabase.UpdateRating(winner, loser, false);

                    userDatabase.AddGameResult(new GameResult
                    {
                        Winner = winner,
                        Loser = loser,
                        IsDraw = false
                    });

                    break;
                }
                else if (IsDraw())
                {
                    Console.WriteLine("It's a draw!");

                    userDatabase.UpdateRating(players[0], players[1], true);

                    userDatabase.AddGameResult(new GameResult
                    {
                        Winner = null,
                        Loser = null,
                        IsDraw = true
                    });
                    break;
                }

                currentPlayerIndex = 1 - currentPlayerIndex;
            }
        }

        private bool IsValidMove(int x, int y)
        {
            return x >= 0 && x < 3 && y >= 0 && y < 3 && grid[x, y] == '\0';
        }

        private bool IsWin(char playerSymbol)
        {
            for (int i = 0; i < 3; i++)
            {
                if (grid[i, 0] == playerSymbol && grid[i, 1] == playerSymbol && grid[i, 2] == playerSymbol ||
                    grid[0, i] == playerSymbol && grid[1, i] == playerSymbol && grid[2, i] == playerSymbol)
                {
                    return true;
                }
            }

            if (grid[0, 0] == playerSymbol && grid[1, 1] == playerSymbol && grid[2, 2] == playerSymbol ||
                grid[0, 2] == playerSymbol && grid[1, 1] == playerSymbol && grid[2, 0] == playerSymbol)
            {
                return true;
            }

            return false;
        }

        private bool IsDraw()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (grid[i, j] == '\0')
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private void PrintGrid()
        {
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(grid[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
