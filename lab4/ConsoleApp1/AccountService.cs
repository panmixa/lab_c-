using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class AccountService:IAccountService
    {
        private IAccountRepository accountRepository;

        public AccountService(IAccountRepository accountRepository) 
        {
            this.accountRepository = accountRepository;
        }

        public GameAccount CreateAccount(string accountType, string username, int rating)
        {
            GameAccount gameAccount = GameFactory.CreateGameAccount(accountType, username, rating);
            accountRepository.Create(gameAccount);
            return gameAccount;
        }

        public IEnumerable<GameAccount> ReadAccounts()
        {
            return accountRepository.Read();
        }

        public IEnumerable<GameAccount> ReadAccountByUsername(string username)
        {
            return accountRepository.Read().Where(a => a.Username == username);
        }
    }
}
