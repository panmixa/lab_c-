using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class WriteAccountsComand:IComand
    {
        private AccountService accountService;
        public readonly static string name = "WriteAccounts";
        public WriteAccountsComand(AccountService accountService) 
        {
            this.accountService = accountService;
        }
        public void TryExecute(string comand, string[] content)
        {
            if(comand == name)
                Console.WriteLine(string.Join(',',accountService.ReadAccounts()));
        }
    }
}
