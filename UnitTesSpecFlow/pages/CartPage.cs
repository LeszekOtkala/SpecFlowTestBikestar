using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesSpecFlow.pages
{
    class CartPage
    {
        public IWebDriver Driver;

        [FindsBy(How = How.XPath, Using = "//li[contains(@class,'success-msg')]//ul//li")]
        IWebElement successMessage;

        public CartPage(IWebDriver driver)
        {
            this.Driver = driver;
            PageFactory.InitElements(driver, this);

        }

        public String GetSuccessMessageText()
        {
            return successMessage.Text;
        }

    }
}
