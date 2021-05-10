using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HW13
{
    public class SquareTests
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
        public void ClickTopLeft()
        {
            _ticTacToePageObject.OpenPage()
                .ClickTopLeft();

            Assert.True(_ticTacToePageObject.IsTopLeftMarked());
        }
        
        [Test]
        public void ClickTop()
        {
            _ticTacToePageObject.OpenPage()
                .ClickTop();

            Assert.True(_ticTacToePageObject.IsTopMarked());
        }
        
        [Test]
        public void ClickTopRight()
        {
            _ticTacToePageObject.OpenPage()
                .ClickTopRight();

            Assert.True((_ticTacToePageObject.IsTopRightMarked()));
        }
        
        [Test]
        public void ClickLeft()
        {
            _ticTacToePageObject.OpenPage()
                .ClickLeft();

            Assert.True(_ticTacToePageObject.IsLeftMarked());
        }
        
        [Test]
        public void ClickCentral()
        {
            _ticTacToePageObject.OpenPage()
                .ClickCentral();

            Assert.True(_ticTacToePageObject.IsCentralMarked());
        }
        
        [Test]
        public void ClickRight()
        {
            _ticTacToePageObject.OpenPage()
                .ClickRight();

            Assert.True(_ticTacToePageObject.IsRightMarked());
        }
        
        [Test]
        public void ClickBottomLeft()
        {
            _ticTacToePageObject.OpenPage()
                .ClickBottomLeft();

            Assert.True(_ticTacToePageObject.IsBottomLeftMarked());
        }
        
        [Test]
        public void ClickBottom()
        {
            _ticTacToePageObject.OpenPage()
                .ClickBottom();

            Assert.True(_ticTacToePageObject.IsBottomMarked());
        }
        
        [Test]
        public void ClickBottomRight()
        {
            _ticTacToePageObject.OpenPage()
                .ClickBottomRight();

            Assert.True(_ticTacToePageObject.IsBottomRightMarked());
        }

        [Test]
        public void CheckPlayer2Response()
        {
            _ticTacToePageObject.OpenPage()
                .ClickTopLeft();
            
            ArrayList squares = new ArrayList();
            squares.Add(_ticTacToePageObject.IsTopMarked());
            squares.Add(_ticTacToePageObject.IsTopRightMarked());
            squares.Add(_ticTacToePageObject.IsLeftMarked());
            squares.Add(_ticTacToePageObject.IsCentralMarked());
            squares.Add(_ticTacToePageObject.IsRightMarked());
            squares.Add(_ticTacToePageObject.IsBottomLeftMarked());
            squares.Add(_ticTacToePageObject.IsBottomMarked());
            squares.Add(_ticTacToePageObject.IsBottomRightMarked());

            foreach (bool x in squares)
            {
                if (x)
                {
                    Assert.True(x);
                }
            }
        }
        
        [Test]
        public void FinishGame()
        {
            _ticTacToePageObject.OpenPage();
            
            ArrayList squares = new ArrayList();
            squares.Add(_ticTacToePageObject.IsTopLeftMarked());
            squares.Add(_ticTacToePageObject.IsTopMarked());
            squares.Add(_ticTacToePageObject.IsTopRightMarked());
            squares.Add(_ticTacToePageObject.IsLeftMarked());
            squares.Add(_ticTacToePageObject.IsCentralMarked());
            squares.Add(_ticTacToePageObject.IsRightMarked());
            squares.Add(_ticTacToePageObject.IsBottomLeftMarked());
            squares.Add(_ticTacToePageObject.IsBottomMarked());
            squares.Add(_ticTacToePageObject.IsBottomRightMarked());

            var counter = true;
            
            while (counter)
            {
                counter = false;

                if (!_ticTacToePageObject.IsTopLeftMarked())
                    _ticTacToePageObject.ClickTopLeft();
                else if (!_ticTacToePageObject.IsTopMarked())
                    _ticTacToePageObject.ClickTop();
                else if (!_ticTacToePageObject.IsTopRightMarked())
                    _ticTacToePageObject.ClickTopRight();
                else if (!_ticTacToePageObject.IsLeftMarked())
                    _ticTacToePageObject.ClickLeft();
                else if (!_ticTacToePageObject.IsCentralMarked())
                    _ticTacToePageObject.ClickCentral();
                else if (!_ticTacToePageObject.IsRightMarked())
                    _ticTacToePageObject.ClickRight();
                else if (!_ticTacToePageObject.IsBottomLeftMarked())
                    _ticTacToePageObject.ClickBottomLeft();
                else if (!_ticTacToePageObject.IsBottomMarked())
                    _ticTacToePageObject.ClickBottom();
                else if (!_ticTacToePageObject.IsBottomRightMarked())
                    _ticTacToePageObject.ClickBottomRight();
                
                foreach (bool x in squares)
                {
                    if (!x)
                    {
                        counter = true;
                    }
                }
                
                var score = int.Parse(_ticTacToePageObject.GetScorePlayer1()) + int.Parse(_ticTacToePageObject.GetScoreTies()) + int.Parse(_ticTacToePageObject.GetScorePlayer2());
                
                if (score > 0)
                {
                    counter = false;
                    Assert.Pass();
                }
            }
            Assert.Fail();
        }
    }
}