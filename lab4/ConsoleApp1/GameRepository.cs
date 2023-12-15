using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class GameRepository:IGameRepository
    {
        private readonly DBContext context;
        public GameRepository (DBContext context)
        {
            this.context = context;
        }

        public void Create(Game game)
        {
            context.CreateGame(game);
        }

        public IEnumerable<Game> Read() 
        {
            return context.ReadGame();
        }

        public void Update(Game gameToUpdate, Game game)
        {
            context.UpdateGame(gameToUpdate,game);
        }
       
        public void Delete(Game game)
        {
            context.DeleteGame(game);
        }
    }
}
