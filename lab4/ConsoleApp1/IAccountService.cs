using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ConsoleApp1
{
    interface IAccountService
    {
        public GameAccount CreateAccount(string accountType, string username, int rating);
        public IEnumerable<GameAccount> ReadAccounts();
        public IEnumerable<GameAccount> ReadAccountByUsername(string username);
    }
}
