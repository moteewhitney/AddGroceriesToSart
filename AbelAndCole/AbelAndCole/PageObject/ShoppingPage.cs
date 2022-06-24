using AbelAndCole.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AbelAndCole.PageObject
{
    class ShoppingPage
    {

        public ShoppingPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;


        IWebElement Search => driver.FindElement(By.XPath("//input[@type='search']"));

        IWebElement SearchGlass => driver.FindElement(By.XPath("//input[@type='button']"));

        IWebElement Add => driver.FindElement(By.XPath("//div[@class='add cta-button']"));

        IWebElement AcceptCookies => driver.FindElement(By.XPath("//button[@id='ccc-notify-accept']"));

        IWebElement Addhummus => driver.FindElement(By.XPath("//div[@class='add-sign plus']"));

        IWebElement Addpopcorn => driver.FindElement(By.XPath("//div[@class='add-sign plus']"));

        IWebElement Search2 => driver.FindElement(By.XPath("//input[@type='search']"));

        IWebElement Basket => driver.FindElement(By.XPath("//span[@class='nb-item']"));


        

        public void Entersearch(string brownie)
        {
            Thread.Sleep(3000);
            Search.SendKeys(brownie);
        }

        public void Clicksearchglass()
        {
            Thread.Sleep(5000);
            SearchGlass.Click();
        }

        public void ClickAcceptCookies()
        {
            Thread.Sleep(5000);
            AcceptCookies.Click();
        }

        public void Clickadd()
        {
            Thread.Sleep(3000);
            Add.Click();
        }

        public void Entersearch2(string hummus)
        {
            Thread.Sleep(3000);
            Search2.SendKeys(hummus);
        }

        public void ClickBasket()
        {
            Basket.Click();
        }

        public void ClickAddpopcorn()
        {
            Addpopcorn.Click();
        }

        public void ClickAddhummus()
        {
            Addhummus.Click();
            Addhummus.Click();
        }








    }
}
