using AbelAndCole.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbelAndCole.PageObject
{
    class CaptchaPage
    {

        public CaptchaPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;


        IWebElement Captcha => driver.FindElement(By.XPath("(//div[@role='presentation'])[4]"));




        public void ClickCaptcha()
        {
            Captcha.Click();
        }




    }
}
