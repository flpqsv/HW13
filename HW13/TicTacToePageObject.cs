using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HW13
{
    public class TicTacToePageObject
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

        private static readonly By _playerXscore = By.XPath("//body/div[4]/p[1]/span[4]");
        private static readonly By _tiesScore = By.XPath("//body/div[4]/p[2]/span[1]");
        private static readonly By _playerOscore = By.XPath("//body/div[4]/p[3]/span[4]");
        private static readonly By _swapButton = By.XPath("//div[@class='swap']");
        private static readonly By _onePlayerIcon = By.CssSelector("[class='p1']");
        private static readonly By _twoPlayersIcon = By.CssSelector("[class='p2']");
        private static readonly By _twoPlayersMode = By.CssSelector("[class='scores p1']");

        private static readonly By _ads = By.XPath("//body/div[5]/ins[1]");

        public TicTacToePageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public TicTacToePageObject OpenPage()
        {
            _webDriver.Navigate().GoToUrl("https://playtictactoe.org/");
            return this;
        }

        public TicTacToePageObject ClickTopLeft()
        {
            _webDriver.FindElement(_topLeftBox).Click();
            Thread.Sleep(500);
            return this;
        }

        public bool IsTopLeftMarked()
        {
            var isMarked = _webDriver.FindElement(_topLeftMarked).Displayed;
            return isMarked;
        }

        public TicTacToePageObject ClickTop()
        {
            _webDriver.FindElement(_topBox).Click();
            Thread.Sleep(500);
            return this;
        }

        public bool IsTopMarked()
        {
            var isMarked = _webDriver.FindElement(_topMarked).Displayed;
            return isMarked;
        }

        public TicTacToePageObject ClickTopRight()
        {
            _webDriver.FindElement(_topRightBox).Click();
            Thread.Sleep(500);
            return this;
        }

        public bool IsTopRightMarked()
        {
            var isMarked = _webDriver.FindElement(_topRightMarked).Displayed;
            return isMarked;
        }

        public TicTacToePageObject ClickLeft()
        {
            _webDriver.FindElement(_leftBox).Click();
            Thread.Sleep(500);
            return this;
        }

        public bool IsLeftMarked()
        {
            var isMarked = _webDriver.FindElement(_leftMarked).Displayed;
            return isMarked;
        }

        public TicTacToePageObject ClickCentral()
        {
            _webDriver.FindElement(_centralBox).Click();
            Thread.Sleep(500);
            return this;
        }

        public bool IsCentralMarked()
        {
            var isMarked = _webDriver.FindElement(_centralMarked).Displayed;
            return isMarked;
        }

        public TicTacToePageObject ClickRight()
        {
            _webDriver.FindElement(_rightBox).Click();
            Thread.Sleep(500);
            return this;
        }

        public bool IsRightMarked()
        {
            var isMarked = _webDriver.FindElement(_rightMarked).Displayed;
            return isMarked;
        }

        public TicTacToePageObject ClickBottomLeft()
        {
            _webDriver.FindElement(_bottomLeftBox).Click();
            Thread.Sleep(500);
            return this;
        }

        public bool IsBottomLeftMarked()
        {
            var isMarked = _webDriver.FindElement(_bottomLeftMarked).Displayed;
            return isMarked;
        }

        public TicTacToePageObject ClickBottom()
        {
            _webDriver.FindElement(_bottomBox).Click();
            Thread.Sleep(500);
            return this;
        }

        public bool IsBottomMarked()
        {
            var isMarked = _webDriver.FindElement(_bottomMarked).Displayed;
            return isMarked;
        }

        public TicTacToePageObject ClickBottomRight()
        {
            _webDriver.FindElement(_bottomRightBox).Click();
            Thread.Sleep(500);
            return this;
        }

        public bool IsBottomRightMarked()
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

        public TicTacToePageObject ClickSwapButton()
        {
            _webDriver.FindElement(_swapButton).Click();
            return this;
        }

        public bool IsPlayer1IconDisplayed()
        {
            var player = _webDriver.FindElement(_onePlayerIcon).Displayed;
            return player;
        }

        public bool IsPlayer2IconDisplayed()
        {
            var player = _webDriver.FindElement(_twoPlayersIcon).Displayed;
            return player;
        }

        public bool AreTwoPlayersModeEnabled()
        {
            var number = _webDriver.FindElement(_twoPlayersMode).Enabled;
            return number;
        }

        public TicTacToePageObject ClickOnAds()
        {
            _webDriver.FindElement(_ads).Click();
            return this;
        }
    }
}