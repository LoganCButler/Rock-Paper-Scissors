using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AppLogic
{
    public class Score
    {
        public int playerScore = 0;
        public int computerScore = 0;
    }
    public class Game
    {
        Score gameScore = new Score();
        public bool gameContinue = true;

        public void PlayARound(string playerMove)
        {
            RunTheRound(playerMove, ComputerMove());
            Console.WriteLine("Player Score {0} : Computer Score {1}\n", gameScore.playerScore , gameScore.computerScore);
        }

        private string ComputerMove()
        {
            string[] computerMoveOptions = { "rock", "paper", "scissors" };

            Random random = new Random();
            return computerMoveOptions[random.Next(0, 3)];
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
                        gameScore.computerScore += 1;
                        break;
                    }
                    if (computerMove == "scissors")
                    {
                        gameScore.playerScore += 1;
                        break;
                    }
                    break;
                case "paper":
                    if (computerMove == "rock")
                    {
                        gameScore.playerScore += 1;
                        break;
                    }
                    if (computerMove == "paper")
                    {
                        break;
                    }
                    if (computerMove == "scissors")
                    {
                        gameScore.computerScore += 1;
                        break;
                    }
                    break;
                case "scissors":
                    if (computerMove == "rock")
                    {
                        gameScore.computerScore += 1;
                        break;
                    }
                    if (computerMove == "paper")
                    {
                        gameScore.playerScore += 1;
                        break;
                    }
                    if (computerMove == "scissors")
                    {
                        break;
                    }
                    break;
            }
            Console.WriteLine("You played {0}, the computer played {1}.", playerMove, computerMove);
            Console.WriteLine( CheckForWin());
        }

        public string CheckForWin()
        {
            if(gameScore.playerScore == 3)
            {
                gameContinue = false;
                return "Player One Wins!";
            }
            if (gameScore.computerScore == 3)
            {
                gameContinue = false;
                return "Computer Wins";
            }
            return "";
        }
    }
}
