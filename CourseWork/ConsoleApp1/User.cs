using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class User
    {
        public string Username { get; set; }
        public char Symbol { get; set; }
        public int Rating { get; set; }

        public User(string username, char symbol)
        {
            Username = username;
            Symbol = symbol;
            Rating = 0;
        }
    }
}
