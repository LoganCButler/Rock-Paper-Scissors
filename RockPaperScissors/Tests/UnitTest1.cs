using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AppLogic;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PlayerWinsWithRockRockRock()
        {
            //arrange
            Game game = new Game();
            game.RunTheRound("rock", "scissors");
            game.RunTheRound("rock", "scissors");
            game.RunTheRound("rock", "scissors");

            //act
            string result = game.CheckForWin();

            //assert
            Assert.AreEqual("Player One Wins!", result);
        }

        [TestMethod]
        public void ComputerWinsWithRockRockRock()
        {
            //arrange
            Game game = new Game();
            game.RunTheRound("scissors", "rock");
            game.RunTheRound("scissors", "rock");
            game.RunTheRound("scissors", "rock");

            //act
            string result = game.CheckForWin();

            //assert
            Assert.AreEqual("Computer Wins", result);
        }

        [TestMethod]
        public void ThreeRoundsWithNoWinner()
        {
            //arrange
            Game game = new Game();
            game.RunTheRound("rock", "rock");
            game.RunTheRound("rock", "rock");
            game.RunTheRound("rock", "rock");

            //act
            string result = game.CheckForWin();

            //assert
            Assert.AreEqual("", result);
        }
    }
}
