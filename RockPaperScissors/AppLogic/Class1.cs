﻿using System;
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
        private int winningScore = 3;
        public bool gameContinue = true;

        //entrypoints
        public string PlayARound(string playerMove, string computerMove)
        {
            RunTheRound(playerMove, computerMove);
            string scorePrintString = ("Player Score " + GetGameScore()[0] + " : Computer Score " + GetGameScore()[1]);            
            Console.WriteLine(scorePrintString + "\n");
            Console.WriteLine(CheckForWin());
            return scorePrintString; //returning for unit test
        }
        public string GetComputerMove()
        {
            return ComputerMove();
        }

        //game logic
        private string ComputerMove()
        {
            string[] computerMoveOptions = { "rock", "paper", "scissors" };

            Random random = new Random();
            return computerMoveOptions[random.Next(0, 3)];
        }

        private void RunTheRound(string playerMove, string computerMove)
        {         
            switch (playerMove)
            {            
                case "rock":                                      
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
                    break;
            }         
            Console.WriteLine("You played {0}, the computer played {1}.", playerMove, computerMove);
        }

        private string CheckForWin()
        {
            if(gameScore.playerScore == winningScore)
            {
                gameContinue = false;
                return "Player One Wins!";
            }
            if (gameScore.computerScore == winningScore)
            {
                gameContinue = false;
                return "Computer Wins";
            }
            return "";
        }


        //This is public to use in testing
        public int[] GetGameScore()
        {
            int[] s = new int[] { gameScore.playerScore, gameScore.computerScore };
            return s;
        }
    }
}
