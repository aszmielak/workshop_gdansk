using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumTests.Pages;

namespace SeleniumTests
{
    [TestFixture]
    public class ContactUsTests : TestBase
    {
        ContactUsPage sut;

        [SetUp]
        public void ContractUsSetup()
        {
            sut = new ContactUsPage(driver);
            sut.GoToPage();
        }

        [Test]
        public void ContactUsEmptySend()
        {
            //driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            //var contactUsButton = driver.FindElement(By.CssSelector("#contact-link"));
            //contactUsButton.Click();
            //var sendButton = driver.FindElement(By.CssSelector("#submitMessage"));
            //sendButton.Click();
            sut.ClickSubmitButton();

            WebDriverWait waitDriver = new WebDriverWait(driver, new TimeSpan(0, 0, 15));
            var errorMessage = waitDriver.Until(ExpectedConditions.ElementExists(By.CssSelector(".alert-danger li")));
            //var errorMessage = driver.FindElement(By.CssSelector("alert-danger li"));

            //string errorString = errorMessage.ToString();
            //StringAssert.Contains("Invalid email address.", errorString);

            Assert.IsTrue(errorMessage.Displayed, "Error message wasn't displayed to user.");
            Assert.That(errorMessage.Text, Contains.Substring("Invalid email address."));
        }
    }
}
