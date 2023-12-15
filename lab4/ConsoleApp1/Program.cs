using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DBContext db = new DBContext();
            AccountRepository accountRepository = new AccountRepository(db);
            GameRepository gameRepository = new GameRepository(db);
            AccountService accountService = new AccountService(accountRepository);
            GameService gameService = new GameService(gameRepository);
            ComandController comandController = new ComandController(accountService,gameService);
            comandController.Execute("WriteAccount Player1");
            comandController.Execute("AddAccount StandardGameAccount Player4 2000");
            comandController.Execute("WriteAccounts");
            while (true)
            {
                comandController.Execute(Console.ReadLine());
            }
        }
    }
}