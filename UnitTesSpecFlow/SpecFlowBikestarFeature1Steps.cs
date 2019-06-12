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
        private HomePage homePage;
        private IntegralHelmetsPage integralHelmetsPage;
        private HelmetProductPage helmetProductPage;
        private CartPage cartPage;
        
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
            homePage = new HomePage(_webDriver);
        }
        
        [When(@"user moves mouse over Helmets in menu")]
        public void WhenUserMovesMouseOverHelmetsInMenu()
        {            
            homePage.MouseOverMainMenuHelmets();                 
        }
        
                
        [When(@"user clicks on integral helmets menu item")]
        public void WhenUserClicksOnIntegralHelmetsMenuItem()
        {           
            homePage.ClickMainMenuItemIntegralHelmets();
            integralHelmetsPage = new IntegralHelmetsPage(_webDriver);
        }
        
        [Then(@"product list of integral helmets is displayed")]
        public void ThenProductListOfIntegralHelmetsIsDisplayed()
        {
            Assert.AreEqual("Kaski Integralne zmknięte - Bikestar.pl", _webDriver.Title);
        }
        [When(@"user clicks on link Rihno Racer helmet")]
        public void WhenUserClicksOnLinkRihnoRacerHelmet()
        {
            integralHelmetsPage.ClickMyHelmet();
            helmetProductPage = new HelmetProductPage(_webDriver);
        }
        [When(@"user select helmet size XL")]
        public void WhenUserSelectHelmetSizeXL()
        {
            helmetProductPage.SelectSize();
        }

        [When(@"user click add to cart button")]
        public void WhenUserClickAddToCartButton()
        {
            helmetProductPage.ClickAddToCart();
            cartPage = new CartPage(_webDriver);

        }

        [Then(@"selected helmet has been added to cart")]
        public void ThenSelectedHelmetHasBeenAddedToCart()
        {
            Assert.AreEqual("KASK RHINO RACER został dodany do Twojego koszyka.", cartPage.GetSuccessMessageText());  
            
        }


        [AfterScenario]
        public void QuitDriver()
        {
            _webDriver.Quit();
        }
    }
}
