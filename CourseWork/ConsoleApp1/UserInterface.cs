using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class UserInterface
    {
        public static string GetUsernameFromUser()
        {
            Console.Write("Enter username: ");
            return Console.ReadLine();
        }

        public static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
