using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AppLogic
{
    public class Game
    {
        private int playerScore = 0;
        private int computerScore = 0;

        public void PlayARound(string playerMove)
        {
            RunTheRound(playerMove, ComputerMove());
            Console.WriteLine("Player Score {0} : Computer Score {1}", playerScore, computerScore);
            CheckForWin();
        }

        private string ComputerMove()
        {
            string[] computerMoveOptions = { "rock", "papper", "sciccors" };

            Random random = new Random();
            return computerMoveOptions[random.Next(0, 2)];
        }

        public void RunTheRound(string playerMove, string computerMove)
        {
            switch (playerMove)
            {
                case "rock":
                    if (computerMove == "rock")
                    {
                        break;
                    }
                    if (computerMove == "paper")
                    {
                        computerScore += 1;
                        break;
                    }
                    if (computerMove == "scissors")
                    {
                        playerScore += 1;
                        break;
                    }
                    break;
                case "papper":
                    if (computerMove == "rock")
                    {
                        playerScore += 1;
                        break;
                    }
                    if (computerMove == "paper")
                    {
                        break;
                    }
                    if (computerMove == "scissors")
                    {
                        computerScore += 1;
                        break;
                    }
                    break;
                case "scissors":
                    if (computerMove == "rock")
                    {
                        computerScore += 1;
                        break;
                    }
                    if (computerMove == "paper")
                    {
                        playerScore += 1;
                        break;
                    }
                    if (computerMove == "scissors")
                    {
                        break;
                    }
                    break;
            }
        }

        public string CheckForWin()
        {
            if(playerScore == 3)
            {
                return "Player One Wins!";
            }
            if (computerScore == 3)
            {
                return "Computer Wins";
            }
            return "";
        }
    }
}
