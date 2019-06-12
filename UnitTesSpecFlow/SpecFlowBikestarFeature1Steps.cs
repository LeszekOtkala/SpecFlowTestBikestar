using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System.Threading;
using UnitTesSpecFlow.pages;

namespace UnitTesSpecFlow
{
    [Binding]
    public class SpecFlowBikestarFeature1Steps
    {
        private readonly IWebDriver _webDriver;
        private readonly IWait<IWebDriver> _defaultWait;
        private HomePage _homePage;
        
        public SpecFlowBikestarFeature1Steps()
        {
            _webDriver = new ChromeDriver();
            _defaultWait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(10))
            {
                PollingInterval = TimeSpan.FromMilliseconds(100)
            };
            _webDriver.Manage().Window.Maximize();
        }
        [Given(@"Bikestar main page has opened")]
        public void GivenBikestarMainPageHasOpened()
        {
            _webDriver.Navigate().GoToUrl("http://www.bikestar.pl/");               
            _homePage = new HomePage(_webDriver);
        }
        
        [When(@"user moves mouse over Helmets in menu")]
        public void WhenUserMovesMouseOverHelmetsInMenu()
        {            
            _homePage.MouseOverMainMenuHelmets();                 
        }
        
                
        [When(@"user clicks on integral helmets menu item")]
        public void WhenUserClicksOnIntegralHelmetsMenuItem()
        {           
            _homePage.ClickMainMenuItemIntegralHelmets();
        }
        
        [Then(@"product list of integral helmets is displayed")]
        public void ThenProductListOfIntegralHelmetsIsDisplayed()
        {
            Assert.AreEqual("Kaski Integralne zmknięte - Bikestar.pl", _webDriver.Title);
        }

      
        [AfterScenario]
        public void QuitDriver()
        {
            _webDriver.Quit();
        }
    }
}
