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
            }
        }

        public string CheckForWin()
        {
            if(playerScore == 3)
            {
                return "Player One Wins!";
            }
            if (playerScore == 3)
            {
                return "Player One Wins";
            }
            return "";
        }
    }
}
