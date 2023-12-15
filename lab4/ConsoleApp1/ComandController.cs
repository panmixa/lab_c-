using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ComandController
    {
        List<IComand> comands = new List<IComand>();
        public ComandController(AccountService accountService, GameService gameService)
        {
            comands.Add(new WriteAccountsComand(accountService));
            comands.Add(new AddAccountComand(accountService));
            comands.Add(new WriteAccountComand(accountService));
        }

        public void Execute(string text)
        {
            string[] content = text.Split();
            foreach(IComand comand in comands)
            {
                comand.TryExecute(content[0], content);
            }
        }
    }
}
