using AbelAndCole.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbelAndCole.PageObject
{
     class LandingPage
    {

        public LandingPage()
        {
            driver = Hooks1.driver; 
        }

        IWebDriver driver;


        IWebElement startshopping => driver.FindElement(By.XPath("(//a[text()='Start shopping'])[1]"));

        

      

        public void NavigateToWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void ClickOnstartshopping()
        {
            startshopping.Click();
        }

        


    }
}
