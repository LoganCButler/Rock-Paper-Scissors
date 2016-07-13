using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AppLogic;

namespace Tests
{
    [TestClass]
    public class AccessingEntryPont
    {
        [TestMethod]
    public void ValidateGameContinue()
        {
            //arrange
            Game game = new Game();
            //act
            game.PlayARound("try",game.GetComputerMove());

            //assert
            Assert.IsTrue(game.gameContinue);
        }

       
    }
    [TestClass]
    public class AccessingPrivateMethods
    {
        [TestMethod]
        public void PlayerWinsWithRockRockRock()
        {
            //arrange
            Game game = new Game();
            game.PlayARound("rock", "scissors");
            game.PlayARound("rock", "scissors");
            game.PlayARound("rock", "scissors");

            //act
            var result = game.GetGameScore();

            //assert
            Assert.AreEqual(3, result[0]);//player score
            Assert.AreEqual(0, result[1]); //computer score
        }

        [TestMethod]
        public void ComputerWinsWithRockRockRock()
        {
            //arrange
            Game game = new Game();
            game.PlayARound("scissors", "rock");
            game.PlayARound("scissors", "rock");
            game.PlayARound("scissors", "rock");

            //act
            var result = game.GetGameScore();

            //assert
            Assert.AreEqual(0, result[0]);//player score
            Assert.AreEqual(3, result[1]); //computer score
        }

        [TestMethod]
        public void ThreeRoundsWithNoWinner()
        {
            //arrange
            Game game = new Game();
            game.PlayARound("rock", "rock");
            game.PlayARound("rock", "rock");
            game.PlayARound("rock", "rock");

            //act
            var result = game.GetGameScore();

            //assert
            Assert.AreEqual(0, result[0]);//player score
            Assert.AreEqual(0, result[1]); //computer score
        }

        [TestMethod]
        public void ComputerCanMakeAMove()
        {
            //arrange
            Game game = new Game();

            //act
            string result = game.GetComputerMove();

            //assert
            Assert.IsNotNull(result);
        }
    }
}
