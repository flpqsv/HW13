using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HW13
{
    public class Square
    {
        internal IWebDriver _webDriver;

        private static readonly By _topLeftBox = By.CssSelector("[class='square top left']");
        private static readonly By _topBox = By.CssSelector("[class='square top']");
        private static readonly By _topRightBox = By.CssSelector("[class='square top right']");
        private static readonly By _leftBox = By.CssSelector("[class='square left']");
        private static readonly By _centralBox = By.CssSelector("[class='square']");
        private static readonly By _rightBox = By.CssSelector("[class='square right']");
        private static readonly By _bottomLeftBox = By.CssSelector("[class='square bottom left']");
        private static readonly By _bottomBox = By.CssSelector("[class='square bottom']");
        private static readonly By _bottomRightBox = By.CssSelector("[class='square bottom right']");

        public Square(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public Square OpenPage()
        {
            _webDriver.Navigate().GoToUrl("https://playtictactoe.org/");
            return this;
        }

        public Square ClickTopLeft()
        {
            _webDriver.FindElement(_topLeftBox).Click();
            return this;
        }
        
        public Square ClickTop()
        {
            _webDriver.FindElement(_topBox).Click();
            return this;
        }
        
        public Square ClickTopRight()
        {
            _webDriver.FindElement(_topRightBox).Click();
            return this;
        }
        
        public Square ClickLeft()
        {
            _webDriver.FindElement(_leftBox).Click();
            return this;
        }
        
        public Square ClickCentral()
        {
            _webDriver.FindElement(_centralBox).Click();
            return this;
        }
        
        public Square ClickRight()
        {
            _webDriver.FindElement(_rightBox).Click();
            return this;
        }
        
        public Square ClickBottomLeft()
        {
            _webDriver.FindElement(_bottomLeftBox).Click();
            return this;
        }
        
        public Square ClickBottom()
        {
            _webDriver.FindElement(_bottomBox).Click();
            return this;
        }
        
        public Square ClickBottomRight()
        {
            _webDriver.FindElement(_bottomRightBox).Click();
            return this;
        }
    }
    public class SquareTests
    
    {
        private IWebDriver _webDriver;
        private Square _square;
        
        [SetUp]
        public void Setup()
        {
            _webDriver = new ChromeDriver("/Users/MaBelle/Downloads/");
            _webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
            _webDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
            _square = new Square(_webDriver);
        }
        
        [TearDown]
        public void TearDown()
        {
            _webDriver.Quit();
        }

        [Test]
        public void ClickTopLeft()
        {
            _square.OpenPage()
                .ClickTopLeft();

            var result = _webDriver.FindElement(By.XPath(".//div[@class = 'square top left']/div[last()]")).Displayed;
            
            Assert.True(result);
        }
        
        [Test]
        public void ClickTop()
        {
            _square.OpenPage()
                .ClickTop();

            var result = _webDriver.FindElement(By.XPath(".//div[@class = 'square top']/div[last()]")).Displayed;
            
            Assert.True(result);
        }
        
        [Test]
        public void ClickTopRight()
        {
            _square.OpenPage()
                .ClickTopRight();

            var result = _webDriver.FindElement(By.XPath(".//div[@class = 'square top right']/div[last()]")).Displayed;
            
            Assert.True(result);
        }
        
        [Test]
        public void ClickLeft()
        {
            _square.OpenPage()
                .ClickLeft();

            var result = _webDriver.FindElement(By.XPath(".//div[@class = 'square left']/div[last()]")).Displayed;
            
            Assert.True(result);
        }
        
        [Test]
        public void ClickCentral()
        {
            _square.OpenPage()
                .ClickCentral();

            var result = _webDriver.FindElement(By.XPath(".//div[@class = 'square']/div[last()]")).Displayed;
            
            Assert.True(result);
        }
        
        [Test]
        public void ClickRight()
        {
            _square.OpenPage()
                .ClickRight();

            var result = _webDriver.FindElement(By.XPath(".//div[@class = 'square right']/div[last()]")).Displayed;
            
            Assert.True(result);
        }
        
        [Test]
        public void ClickBottomLeft()
        {
            _square.OpenPage()
                .ClickBottomLeft();

            var result = _webDriver.FindElement(By.XPath(".//div[@class = 'square bottom left']/div[last()]")).Displayed;
            
            Assert.True(result);
        }
        
        [Test]
        public void ClickBottom()
        {
            _square.OpenPage()
                .ClickBottom();

            var result = _webDriver.FindElement(By.XPath(".//div[@class = 'square bottom']/div[last()]")).Displayed;
            
            Assert.True(result);
        }
        
        [Test]
        public void ClickBottomRight()
        {
            _square.OpenPage()
                .ClickBottomRight();

            var result = _webDriver.FindElement(By.XPath(".//div[@class = 'square bottom right']/div[last()]")).Displayed;
            
            Assert.True(result);
        }
    }
}