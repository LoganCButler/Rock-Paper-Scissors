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
            while (rps.gameContinue)
            {
                Console.WriteLine("Enter in a move: rock, paper, or scissors.");
                rps.PlayARound(Console.ReadLine(), rps.GetComputerMove());
            }
            Console.WriteLine("Good Game!");
            Console.ReadLine();
        }
    }
}
