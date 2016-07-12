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

        public void play(string playerMove, string computerMove)
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
