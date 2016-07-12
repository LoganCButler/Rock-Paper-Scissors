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
    }
}
