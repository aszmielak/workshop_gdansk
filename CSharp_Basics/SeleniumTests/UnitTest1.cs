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
            ////gra do zabawy css selectorów: https://flukeout.github.io/#
            ////wtyczka do Chroma "Web Developer" koło zebate ikonka
            var waitTime = new TimeSpan(0, 0, 1);
            driver.Manage().Timeouts().ImplicitWait = waitTime;
        }

        [Test]
        public void FirstTest()  ////metoda
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            var categoryHeader = driver.FindElement(By.CssSelector("ul.sf-menu > li> a[title='Dresses']"));
            categoryHeader.Click();
            var productCounter = driver.FindElement(By.CssSelector(".heading-counter"));
            string text = productCounter.Text;

            StringAssert.Contains("5", text);
        }

        [Test]
        public void SecondTest()  ////metoda
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            var categoryHeader = driver.FindElement(By.CssSelector("ul.sf-menu > li> a[title='Women']"));
            categoryHeader.Click();
            var productCounter = driver.FindElement(By.CssSelector(".heading-counter"));
            string text = productCounter.Text;

            StringAssert.Contains("7", text);
        }

        [Test]
        public void ThirdTest()  ////metoda
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            var categoryHeader = driver.FindElement(By.CssSelector("ul.sf-menu > li> a[title='T-shirts']"));
            categoryHeader.Click();
            var productCounter = driver.FindElement(By.CssSelector(".heading-counter"));
            string text = productCounter.Text;

            StringAssert.Contains("1", text);
        }

        [TearDown]
        public void TearDown()
        {
           driver.Quit();
        }
    }
}
