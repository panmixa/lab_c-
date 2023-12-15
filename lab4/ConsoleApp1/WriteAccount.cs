using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class WriteAccountComand : IComand
    {
        private AccountService accountService;
        public readonly static string name = "WriteAccount";
        public WriteAccountComand(AccountService accountService)
        {
            this.accountService = accountService;
        }
        public void TryExecute(string comand, string[] content)
        {
            if (comand == name)
                Console.WriteLine(string.Join(',', accountService.ReadAccountByUsername(content[1])));
        }
    }
}
