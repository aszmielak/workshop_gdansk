using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests.Pages
{
    public class ContactUsPage
    {
        private IWebDriver driver;
        private WebDriverWait waitDriver;
        private By submitButtonLocator = By.CssSelector("#submitMessage");
        private By errorMessageLocator = By.CssSelector(".alert-danger li");

        public ContactUsPage(IWebDriver driver)
        {
            this.driver = driver;
            waitDriver = new WebDriverWait(driver, new TimeSpan(0, 0, 15));
        }

        public bool IsErrorMessageDisplayed()
        {
            var errorMessage = waitDriver.Until(ExpectedConditions.ElementExists(errorMessageLocator));
            return errorMessage.Displayed;
        }

        public void GoToPage()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=contact");
        }

        public void ClickSubmitButton()
        {
            driver.FindElement(submitButtonLocator).Click();
        }

        public string GetErrorMessageTest()
        {
            var errorMessage = waitDriver.Until(ExpectedConditions.ElementExists(errorMessageLocator));
            return errorMessage.Text;
        }
    }
}
