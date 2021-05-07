using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HW13
{
    public class SquareTests
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
        public void ClickTopLeft()
        {
            _pageObject.OpenPage()
                .ClickTopLeft();

            Assert.True(_pageObject.IsTopLeftMarked());
        }
        
        [Test]
        public void ClickTop()
        {
            _pageObject.OpenPage()
                .ClickTop();

            Assert.True(_pageObject.IsTopMarked());
        }
        
        [Test]
        public void ClickTopRight()
        {
            _pageObject.OpenPage()
                .ClickTopRight();

            Assert.True((_pageObject.IsTopRightMarked()));
        }
        
        [Test]
        public void ClickLeft()
        {
            _pageObject.OpenPage()
                .ClickLeft();

            Assert.True(_pageObject.IsLeftMarked());
        }
        
        [Test]
        public void ClickCentral()
        {
            _pageObject.OpenPage()
                .ClickCentral();

            Assert.True(_pageObject.IsCentralMarked());
        }
        
        [Test]
        public void ClickRight()
        {
            _pageObject.OpenPage()
                .ClickRight();

            Assert.True(_pageObject.IsRightMarked());
        }
        
        [Test]
        public void ClickBottomLeft()
        {
            _pageObject.OpenPage()
                .ClickBottomLeft();

            Assert.True(_pageObject.IsBottomLeftMarked());
        }
        
        [Test]
        public void ClickBottom()
        {
            _pageObject.OpenPage()
                .ClickBottom();

            Assert.True(_pageObject.IsBottomMarked());
        }
        
        [Test]
        public void ClickBottomRight()
        {
            _pageObject.OpenPage()
                .ClickBottomRight();

            Assert.True(_pageObject.IsBottomRightMarked());
        }
    }
}