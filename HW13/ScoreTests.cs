using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace HW13
{ public class ScoresTests
    {
        private IWebDriver _webDriver;
        private TicTacToePageObject _ticTacToePageObject;
        
        [SetUp]
        public void Setup()
        {
            _webDriver = new ChromeDriver("/Users/MaBelle/Downloads/");
            _webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
            _webDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
            _ticTacToePageObject = new TicTacToePageObject(_webDriver);
        }
        
        [TearDown]
        public void TearDown()
        {
            _webDriver.Quit();
        }

        [Test]
        public void CheckDefaultNumberOfPlayers()
        {
            _ticTacToePageObject.OpenPage();
            
            Assert.True(_ticTacToePageObject.AreTwoPlayersModeEnabled());
        }

        [Test]
        public void CheckDefaultPlayer()
        {
            _ticTacToePageObject.OpenPage();
            
            Assert.Multiple(() =>
            {
                Assert.True(_ticTacToePageObject.IsPlayer1IconDisplayed()); 
                Assert.False(_ticTacToePageObject.IsPlayer2IconDisplayed());
            });
        }

        [Test]
        public void CheckDefaultScorePlayer1()
        {
            _ticTacToePageObject.OpenPage();
            
            var expected = "0";
            
            Assert.AreEqual(expected, _ticTacToePageObject.GetScorePlayer1());
        }
        
        [Test]
        public void CheckDefaultScoreTies()
        {
            _ticTacToePageObject.OpenPage();
            
            var expected = "0";
            
            Assert.AreEqual(expected, _ticTacToePageObject.GetScoreTies());
        }
        
        [Test]
        public void CheckDefaultScorePlayer2()
        {
            _ticTacToePageObject.OpenPage();
            
            var expected = "0";
            
            Assert.AreEqual(expected, _ticTacToePageObject.GetScorePlayer2());
        }

        [Test]
        public void SwapPlayers()
        {
            _ticTacToePageObject.OpenPage()
                .ClickSwapButton();
            
            Assert.True(_ticTacToePageObject.IsPlayer2IconDisplayed());
        }
        
        [Test]
        public void OpenAds()
        {
            _ticTacToePageObject.OpenPage()
                .ClickOnAds();
            
            Thread.Sleep(1000);
            
            Assert.AreNotEqual("https://playtictactoe.org/", _webDriver.Url);
        }
    }
}