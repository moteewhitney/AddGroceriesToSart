using AbelAndCole.PageObject;
using System;
using TechTalk.SpecFlow;

namespace AbelAndCole.StepDefinition
{
    [Binding]
    public class IfIShopOnlineAbelAndColeSteps
    {
        LandingPage landingPage;

        ShoppingPage shoppingPage;

        CaptchaPage captchaPage;

        public IfIShopOnlineAbelAndColeSteps()
        {
            landingPage = new LandingPage();

            shoppingPage = new ShoppingPage();

            captchaPage = new CaptchaPage();
        }







        [Given(@"i navigate to the website ""(.*)""")]
        public void GivenINavigateToTheWebsite(string url)
        {
            landingPage.NavigateToWebsite(url);
        }
        
        [Given(@"i click on start shopping")]
        public void GivenIClickOnStartShopping()
        {
            landingPage.ClickOnstartshopping();
        }
        
        [Given(@"i search groceries ""(.*)""")]
        public void GivenISearchGroceries(string brownie)
        {
            shoppingPage.Entersearch(brownie);
        }


        [Given(@"i click the search glass")]
        public void GivenIClickTheSearchGlass()
        {
            shoppingPage.Clicksearchglass();
        }


        [Given(@"i click on add")]
        public void GivenIClickOnAdd()
        {
            shoppingPage.Clickadd();
        }

        [Given(@"i search groceries2 ""(.*)""")]
        public void GivenISearchGroceries2(string hummus)
        {
            shoppingPage.Entersearch2(hummus);
        }

        [Given(@"i click on plussshummus")]
        public void GivenIClickOnPlussshummus()
        {
            shoppingPage.ClickAddhummus();
        }


        [Given(@"i click on plusspopcorn")]
        public void GivenIClickOnPlusspopcorn()
        {
            shoppingPage.ClickAddpopcorn();
        }


        [When(@"i click on my basket")]
        public void GivenIClickOnMyBasket()
        {
            shoppingPage.ClickBasket();
        }

        [Given(@"i accept cookies")]
        public void GivenIAcceptCookies()
        {
            shoppingPage.ClickAcceptCookies();
        }










    }
}
