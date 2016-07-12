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
            game.play("rock", "scissors");
            game.play("rock", "scissors");
            game.play("rock", "scissors");

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
            game.play("scissors", "rock");
            game.play("scissors", "rock");
            game.play("scissors", "rock");

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
            game.play("rock", "rock");
            game.play("rock", "rock");
            game.play("rock", "rock");

            //act
            string result = game.CheckForWin();

            //assert
            Assert.AreEqual("", result);
        }
    }
}
