using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HW13
{
    public class Scores
    {
        internal IWebDriver _webDriver;

        private static readonly By _playerXscore = By.XPath("//p[@class='player1']/span[@class='score']");
        private static readonly By _tiesScore = By.XPath("//p[@class='ties']/span[@class='score']");
        private static readonly By _playerOscore = By.XPath("//p[@class='player2']/span[@class='score']");
        private static readonly By _swapButton = By.ClassName("[class='swap']");

        public Scores(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public Scores OpenPage()
        {
            _webDriver.Navigate().GoToUrl("https://playtictactoe.org/");
            return this;
        }

        public string GetScorePlayer1()
        {
            var score = _webDriver.FindElement(_playerXscore).Text;
            return score;
        }
        
        public string GetScoreTies()
        {
            var score = _webDriver.FindElement(_tiesScore).Text;
            return score;
        }
        
        public string GetScorePlayer2()
        {
            var score = _webDriver.FindElement(_playerOscore).Text;
            return score;
        }

        public Scores ClickSwapButton()
        {
            _webDriver.FindElement(_swapButton).Click();
            return this;
        }
    }
    public class ScoresTests
    
    {
        private IWebDriver _webDriver;
        private Scores _scores;
        
        [SetUp]
        public void Setup()
        {
            _webDriver = new ChromeDriver("/Users/MaBelle/Downloads/");
            _webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
            _webDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
            _scores = new Scores(_webDriver);
        }
        
        [TearDown]
        public void TearDown()
        {
            _webDriver.Quit();
        }

        [Test]
        public void CheckDefaultNumberOfPlayers()
        {
            _scores.OpenPage();

            var result = _webDriver.FindElement(By.CssSelector("[class='scores p1']")).Enabled;
            
            Assert.True(result);
        }

        [Test]
        public void CheckDefaultPlayer()
        {
            _scores.OpenPage();
            
            var player1 = _webDriver.FindElement(By.CssSelector("[class='p1']")).Displayed;
            var player2 = _webDriver.FindElement(By.CssSelector("[class='p2']")).Displayed;
            
            Assert.Multiple(() =>
            {
                Assert.True(player1); 
                Assert.False(player2);
            });
        }

        [Test]
        public void CheckDefaultScorePlayer1()
        {
            _scores.OpenPage();
            
            var expected = "0";
            var actual = _scores.GetScorePlayer1();
            
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void CheckDefaultScoreTies()
        {
            _scores.OpenPage();
            
            var expected = "0";
            var actual = _scores.GetScoreTies();
            
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void CheckDefaultScorePlayer2()
        {
            _scores.OpenPage();
            
            var expected = "0";
            var actual = _scores.GetScorePlayer2();
            
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SwapPlayers()
        {
            _scores.OpenPage()
                .ClickSwapButton();
            
            Assert.True(_webDriver.FindElement(By.CssSelector("[class='p2']")).Displayed);
        }
    }
}