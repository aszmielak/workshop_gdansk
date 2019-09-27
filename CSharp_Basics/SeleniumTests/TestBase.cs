using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTests
{
    public class TestBase
    {
        protected IWebDriver driver; //protected - dostępne dla dzieci, a nie dla innych class

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

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
