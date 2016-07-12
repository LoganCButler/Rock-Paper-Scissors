using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppLogic;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Game rps = new Game();
            while (true)
            {
                Console.WriteLine("Enter in a move");
                rps.PlayARound(Console.ReadLine());
            }
        }
    }
}
