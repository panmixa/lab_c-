using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class AddAccountComand:IComand
    {
        private AccountService accountService;
        public readonly static string name = "AddAccount";
        public AddAccountComand(AccountService accountService)
        {
            this.accountService = accountService;
        }
        public void TryExecute(string comand, string[] content)
        {
            if (comand == name && content.Length >=4 && int.TryParse(content[3],out int b))
                accountService.CreateAccount(content[1], content[2], b);
        }
    }
}
