using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HW13
{ public class ScoresTests
    {
        private IWebDriver _webDriver;
        private PageObject _pageObject;
        
        [SetUp]
        public void Setup()
        {
            _webDriver = new ChromeDriver("/Users/MaBelle/Downloads/");
            _webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
            _webDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
            _pageObject = new PageObject(_webDriver);
        }
        
        [TearDown]
        public void TearDown()
        {
            _webDriver.Quit();
        }

        [Test]
        public void CheckDefaultNumberOfPlayers()
        {
            _pageObject.OpenPage();
            
            Assert.True(_pageObject.GetNumberOfPlayers());
        }

        [Test]
        public void CheckDefaultPlayer()
        {
            _pageObject.OpenPage();
            
            Assert.Multiple(() =>
            {
                Assert.True(_pageObject.GetPlayer1()); 
                Assert.False(_pageObject.GetPlayer2());
            });
        }

        [Test]
        public void CheckDefaultScorePlayer1()
        {
            _pageObject.OpenPage();
            
            var expected = "0";
            var actual = _pageObject.GetScorePlayer1();
            
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void CheckDefaultScoreTies()
        {
            _pageObject.OpenPage();
            
            var expected = "0";
            
            Assert.AreEqual(expected, _pageObject.GetScoreTies());
        }
        
        [Test]
        public void CheckDefaultScorePlayer2()
        {
            _pageObject.OpenPage();
            
            var expected = "0";
            
            Assert.AreEqual(expected, _pageObject.GetScorePlayer2());
        }

        [Test]
        public void SwapPlayers()
        {
            _pageObject.OpenPage()
                .ClickSwapButton();
            
            Assert.True(_pageObject.GetPlayer2());
        }
    }
}