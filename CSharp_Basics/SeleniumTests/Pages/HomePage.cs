using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTests.Pages
{
    public class HomePage
    {
        private IWebDriver driver;
        private WebDriverWait waitDriver;
        private By womenButtonLocator = By.CssSelector("ul.sf-menu > li> a[title='Women']");
        private By dressesButtonLocator = By.CssSelector("ul.sf-menu > li > a[title='Dresses']");
        private By tshirtButtonLocator = By.CssSelector("ul.sf-menu > li > a[title='T-shirts']");

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            waitDriver = new WebDriverWait(driver, new TimeSpan(0, 0, 15));
        }
        public void GoToPage()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }
        public void ClickWomenButton()
        {
            driver.FindElement(womenButtonLocator).Click();
        }

        public void ClickDressesButton()
        {
            driver.FindElement(dressesButtonLocator).Click();
        }
        public void ClickTshirtButton()
        {
            driver.FindElement(tshirtButtonLocator).Click();
        }
    }
}
