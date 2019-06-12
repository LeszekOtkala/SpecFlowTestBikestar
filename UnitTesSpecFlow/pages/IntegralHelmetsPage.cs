using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesSpecFlow.pages
{    

    class IntegralHelmetsPage
    {

        public IWebDriver Driver;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'KASK RHINO RACER')]")]
        IWebElement myHelmet;

        public IntegralHelmetsPage(IWebDriver driver)
        {
            this.Driver = driver;
            PageFactory.InitElements(driver, this);
            
        }
        public void ClickMyHelmet()
        {
            myHelmet.Click();
        }



    }
}
