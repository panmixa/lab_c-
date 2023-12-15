using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class AccountRepository : IAccountRepository
    {
        private readonly DBContext context;
        public AccountRepository(DBContext context)
        {
            this.context = context;
        }

        public void Create(GameAccount account)
        {
            context.CreateAccount(account);
        }

        public IEnumerable<GameAccount> Read()
        {
            return context.ReadAccounts();
        }

        public void Update(GameAccount gameToUpdate, GameAccount account)
        {
            context.UpdateAccount(gameToUpdate, account);
        }

        public void Delete(GameAccount account)
        {
            context.DeleteAccount(account);
        }
    }
}
