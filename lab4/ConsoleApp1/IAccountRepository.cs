using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal interface IAccountRepository
    {
        public void Create(GameAccount gameAccount);
        public IEnumerable<GameAccount> Read();
        public void Update(GameAccount gameAccountToUpdate, GameAccount account);
        public void Delete(GameAccount gameAccount);
    }
}
