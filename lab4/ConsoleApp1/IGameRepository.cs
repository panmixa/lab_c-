using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal interface IGameRepository
    {
        public void Create(Game game);
        public IEnumerable<Game> Read();
        public void Update(Game gameToUpdate, Game game);
        public void Delete(Game game);
    }
}
