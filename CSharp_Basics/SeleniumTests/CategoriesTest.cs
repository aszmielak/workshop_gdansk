using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTests
{
    [TestFixture]
    public class CategoriesTest : TestBase  //zadziedziczone
    {
        [Test]
        public void FirstTest()  ////metoda
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            var categoryHeader = driver.FindElement(By.CssSelector("ul.sf-menu > li> a[title='Dresses']"));
            categoryHeader.Click();
            var productCounter = driver.FindElement(By.CssSelector(".heading-counter"));
            string text = productCounter.Text;
            var webElements = driver.FindElements(By.CssSelector("div.product-container"));

            string actualElementCount = webElements.Count.ToString();
            StringAssert.Contains(actualElementCount, text);
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
    }
}
