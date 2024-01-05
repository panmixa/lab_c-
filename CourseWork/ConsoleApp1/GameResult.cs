using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class GameResult
    {
        public User Winner { get; set; }
        public User Loser { get; set; }
        public bool IsDraw { get; set; }
    }
}
