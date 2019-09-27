using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTests
{
    [TestFixture]
    public class UnitTest1
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            ////konstruktor klasy drivera
            driver = new ChromeDriver();
        }

        [Test]
        public void FirstTest()  ////metoda
        {
            Assert.AreEqual(2, 1);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
