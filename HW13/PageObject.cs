using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HW13
{
    public class PageObject
    {
        private IWebDriver _webDriver;

        private static readonly By _topLeftBox = By.CssSelector("[class='square top left']");
        private static readonly By _topBox = By.CssSelector("[class='square top']");
        private static readonly By _topRightBox = By.CssSelector("[class='square top right']");
        private static readonly By _leftBox = By.CssSelector("[class='square left']");
        private static readonly By _centralBox = By.CssSelector("[class='square']");
        private static readonly By _rightBox = By.CssSelector("[class='square right']");
        private static readonly By _bottomLeftBox = By.CssSelector("[class='square bottom left']");
        private static readonly By _bottomBox = By.CssSelector("[class='square bottom']");
        private static readonly By _bottomRightBox = By.CssSelector("[class='square bottom right']");

        private static readonly By _topLeftMarked = By.XPath(".//div[@class = 'square top left']/div[last()]");
        private static readonly By _topMarked = By.XPath(".//div[@class = 'square top']/div[last()]");
        private static readonly By _topRightMarked = By.XPath(".//div[@class = 'square top right']/div[last()]");
        private static readonly By _leftMarked = By.XPath(".//div[@class = 'square left']/div[last()]");
        private static readonly By _centralMarked = By.XPath(".//div[@class = 'square']/div[last()]");
        private static readonly By _rightMarked = By.XPath(".//div[@class = 'square right']/div[last()]");
        private static readonly By _bottomLeftMarked = By.XPath(".//div[@class = 'square bottom left']/div[last()]");
        private static readonly By _bottomMarked = By.XPath(".//div[@class = 'square bottom']/div[last()]");
        private static readonly By _bottomRightMarked = By.XPath(".//div[@class = 'square bottom right']/div[last()]");

        private static readonly By _playerXscore = By.XPath("//p[@class='player1']/span[@class='score']");
        private static readonly By _tiesScore = By.XPath("//p[@class='ties']/span[@class='score']");
        private static readonly By _playerOscore = By.XPath("//p[@class='player2']/span[@class='score']");
        private static readonly By _swapButton = By.XPath("//div[@class='swap']");
        private static readonly By _onePlayerIcon = By.CssSelector("[class='p1']");
        private static readonly By _twoPlayersIcon = By.CssSelector("[class='p2']");

        public PageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public PageObject OpenPage()
        {
            _webDriver.Navigate().GoToUrl("https://playtictactoe.org/");
            return this;
        }

        public PageObject ClickTopLeft()
        {
            _webDriver.FindElement(_topLeftBox).Click();
            return this;
        }

        public bool GetTopLeftStatus()
        {
            var isMarked = _webDriver.FindElement(_topLeftMarked).Displayed;
            return isMarked;
        }

        public PageObject ClickTop()
        {
            _webDriver.FindElement(_topBox).Click();
            return this;
        }

        public bool GetTopStatus()
        {
            var isMarked = _webDriver.FindElement(_topMarked).Displayed;
            return isMarked;
        }

        public PageObject ClickTopRight()
        {
            _webDriver.FindElement(_topRightBox).Click();
            return this;
        }

        public bool GetTopRightStatus()
        {
            var isMarked = _webDriver.FindElement(_topRightMarked).Displayed;
            return isMarked;
        }

        public PageObject ClickLeft()
        {
            _webDriver.FindElement(_leftBox).Click();
            return this;
        }

        public bool GetLeftStatus()
        {
            var isMarked = _webDriver.FindElement(_leftMarked).Displayed;
            return isMarked;
        }

        public PageObject ClickCentral()
        {
            _webDriver.FindElement(_centralBox).Click();
            return this;
        }

        public bool GetCentralStatus()
        {
            var isMarked = _webDriver.FindElement(_centralMarked).Displayed;
            return isMarked;
        }

        public PageObject ClickRight()
        {
            _webDriver.FindElement(_rightBox).Click();
            return this;
        }

        public bool GetRightStatus()
        {
            var isMarked = _webDriver.FindElement(_rightMarked).Displayed;
            return isMarked;
        }

        public PageObject ClickBottomLeft()
        {
            _webDriver.FindElement(_bottomLeftBox).Click();
            return this;
        }

        public bool GetBottomLeftStatus()
        {
            var isMarked = _webDriver.FindElement(_bottomLeftMarked).Displayed;
            return isMarked;
        }

        public PageObject ClickBottom()
        {
            _webDriver.FindElement(_bottomBox).Click();
            return this;
        }

        public bool GetBottomStatus()
        {
            var isMarked = _webDriver.FindElement(_bottomMarked).Displayed;
            return isMarked;
        }

        public PageObject ClickBottomRight()
        {
            _webDriver.FindElement(_bottomRightBox).Click();
            return this;
        }

        public bool GetBottomRightStatus()
        {
            var isMarked = _webDriver.FindElement(_bottomRightMarked).Displayed;
            return isMarked;
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

        public PageObject ClickSwapButton()
        {
            _webDriver.FindElement(_swapButton).Click();
            return this;
        }

        public bool GetPlayer1()
        {
            var player = _webDriver.FindElement(_onePlayerIcon).Displayed;
            return player;
        }

        public bool GetPlayer2()
        {
            var player = _webDriver.FindElement(_twoPlayersIcon).Displayed;
            return player;
        }

        public bool GetNumberOfPlayers()
        {
            var number = _webDriver.FindElement(By.CssSelector("[class='scores p1']")).Enabled;
            return number;
        }
    }
}