using NUnit.Framework;
using BlackJackMVC.Models;

namespace BlackJack.UnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            

        }
        CardValues cardValues = new CardValues();
        [Test]
        public void GetScore()
        {
            
            var score = cardValues.getScoreFromString("17");

            Assert.IsNotNull(score);
        }

        [Test]

        public void WinnerGoTest()
        {
            var winner = cardValues.WinnerCheck(19, 21);
            
            Assert.IsNotEmpty(winner);
        }
    }
}