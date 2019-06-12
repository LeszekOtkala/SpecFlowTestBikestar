using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;

namespace UnitTesSpecFlow.pages
{
    class HomePage
    {
       public IWebDriver Driver;
        [FindsBy(How = How.XPath, Using = "//li[@class='level0 nav-10 first parent']//span[contains(text(),'Kaski')]")]
        IWebElement mainMenuHelmets;
        [FindsBy(How = How.XPath, Using = "//li[@class='level1 nav-10-1 first title']//a[contains(text(),'Kaski Integralne')]")]
        IWebElement mainMenuItemIntegralHelmets;

        public HomePage(IWebDriver driver)
        {
            this.Driver = driver;
            PageFactory.InitElements(driver, this);

        }

        public void ClickMainMenuItemIntegralHelmets()
        {
            mainMenuItemIntegralHelmets.Click();
        }

        public void MouseOverMainMenuHelmets()
        {
            Actions actions = new Actions(Driver);
            actions.Build();
            actions.MoveToElement(mainMenuHelmets, 0, 0);
            actions.Perform();
        }
    }
}
