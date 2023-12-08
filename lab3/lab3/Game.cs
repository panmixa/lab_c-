using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Game
    {
        public int GameId { get; set; }
        public string OpponentName { get; set; }
        public bool IsWin { get; set; }
        public int RatingChange { get; set; }
        public int PlayerId { get; set; }

    }
}
