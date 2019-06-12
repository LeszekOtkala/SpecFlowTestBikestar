using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesSpecFlow.pages
{
    class HelmetProductPage
    {
        public IWebDriver Driver;

        [FindsBy(How = How.XPath, Using = "//select[@id='attribute134']")]
        IWebElement selectSize;

        [FindsBy(How = How.XPath, Using = "//button[@class='button btn-cart']")]
        IWebElement addToCartButton;


        public HelmetProductPage(IWebDriver driver)
        {
            this.Driver = driver;
            PageFactory.InitElements(driver, this);

        }
        
        public void SelectSize()
        {
            var selectElement = new SelectElement(selectSize);
            selectElement.SelectByText("XL");
        }

        public void ClickAddToCart()
        {
            addToCartButton.Click();
        }


    }
}
