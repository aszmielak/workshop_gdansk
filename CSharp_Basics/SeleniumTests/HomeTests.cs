using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumTests.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTests
{
    [TestFixture]
    public class HomeTests : TestBase
    {
        HomePage sut;

        [SetUp]
        public void ContractUsSetup()
        {
            sut = new HomePage(driver);
            sut.GoToPage();
        }

        [Test]
        public void ClickWomenButton()
        {           
            sut.ClickWomenButton();
            ProductCounter();
        }

        [Test]
        public void ClickDressesButton()
        {
            sut.ClickDressesButton();
            ProductCounter();
        }

        [Test]
        public void ClickTshirtButton()
        {
            sut.ClickTshirtButton();
            ProductCounter();
        }

        public void ProductCounter()
        {
            var productCounter = driver.FindElement(By.CssSelector(".heading-counter"));
            string text = productCounter.Text;
            var webElements = driver.FindElements(By.CssSelector("div.product-container"));
            string actualElementCount = webElements.Count.ToString();
            StringAssert.Contains(actualElementCount, text);
        }
    }
}
