using BDD_TastyNibbles.Hooks;
using BDD_TastyNibbles.Utilities;
using FluentAssertions.Equivalency;
using NUnit.Framework;
using OpenQA.Selenium;
using Serilog;
using System;
using TechTalk.SpecFlow;

namespace BDD_TastyNibbles.StepDefinitions
{
    [Binding]
    public class SearchProductAndAddtoCartAndCheckOutSteps:CoreCodes
    {
        IWebDriver? driver = AllHooks.driver;

        [Given(@"User will be on the home page")]
        public void GivenUserWillBeOnTheHomePage()
        {
            driver.Url = "https://www.tastynibbles.in/";
            driver.Manage().Window.Maximize();
        }

        [When(@"User will type the '([^']*)' in the search box")]
        public void WhenUserWillTypeTheInTheSearchBox(string searchtext)
        {
            IWebElement? searchInput = driver.FindElement(By.XPath("(//input[@class='site-header__search-input'])[position()=1]"));
            searchInput?.SendKeys(searchtext);
            Log.Information("Typed search text " + searchtext);
            searchInput?.SendKeys(Keys.Enter);
        }

        [Then(@"The Title should have '([^']*)'")]
        public void ThenTheTitleShouldHave(string searchtext)
        {
            TakeScreenShot(driver);
            try
            {
                Assert.That(driver.Title, Does.Contain(searchtext));
                LogTestResult("Title Test", "Title Test success");
            }
            catch (AssertionException ex)
            {
                LogTestResult("Title Test", "Title Test Failed", ex.Message);
            }

        }
        [When(@"User will click on product")]
        public void WhenUserWillClickOnProduct()
        {
            IWebElement? product = driver.FindElement(By.XPath("(//div[contains(@class,'new-grid search-grid')]//following::div[contains(@data-product-handle,'ghee-rice-250g')])[position()=1]"));
            product.Click();
            Log.Information("Clicked on product");  
        }
        [When(@"User will click on size")]
        public void WhenUserWillClickOnSize()
        {
            Thread.Sleep(1000);
            IWebElement? size = driver.FindElement(By.XPath("//label[@class='variant__button-label' and text()='Pack 1']"));
            //((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", size);
            size.Click();
            Log.Information("Clicked on size");
        }
        [When(@"User will click on Add to Cart")]
        public void WhenUserWillClickOnAddToCart()
        {
            IWebElement? addToCart = driver.FindElement(By.Name("add"));
            addToCart.Click();
            Log.Information("Clicked on Add to Cart Button");
        }
        [When(@"User will click on CheckOut button")]
        public void WhenUserWillClickOnCheckOutButton()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            IWebElement? checkOut = driver.FindElement(By.Name("checkout"));
            checkOut.Click();
            Log.Information("Clicked on Check Out Button");
        }

        [When(@"User will type the '([^']*)' in the input")]
        public void WhenUserWillTypeTheInTheInput(string email)
        {
            IWebElement? emailInput = driver.FindElement(By.Id("email"));
            emailInput?.SendKeys(email);
            emailInput.SendKeys(Keys.Enter);
            Log.Information("Typed email");
        }
        [When(@"User will type the '([^']*)' in the input box")]
        public void WhenUserWillTypeTheInTheInputBox(string firstname)
        {
            IWebElement? firstnameInput = driver.FindElement(By.Name("firstName"));
            firstnameInput?.SendKeys(firstname);
            firstnameInput?.SendKeys(Keys.Enter);
            Log.Information("Typed first name");
        }
        [When(@"User will type the '([^']*)' inside input")]
        public void WhenUserWillTypeTheInsideInput(string lastname)
        {
            IWebElement? lastnameInput = driver.FindElement(By.Name("lastName"));
            lastnameInput?.SendKeys(lastname);
            lastnameInput?.SendKeys(Keys.Enter);
            Log.Information("Typed last name");
        }
        [When(@"User will type the '([^']*)' inside inputbox")]
        public void WhenUserWillTypeTheInsideInputbox(string address)
        {
            IWebElement? addressInput = driver.FindElement(By.Name("address1"));
            addressInput?.SendKeys(address);
            addressInput?.SendKeys(Keys.Enter);
            Log.Information("Typed address");
        }
        [When(@"User will enter the '([^']*)'")]
        public void WhenUserWillEnterThe(string city)
        {
            IWebElement? cityInput = driver.FindElement(By.Name("city"));
            cityInput?.SendKeys(city);
            cityInput?.SendKeys(Keys.Enter);
            Log.Information("Typed city");
        }

        [When(@"User will click on State dropdown")]
        public void WhenUserWillClickOnStateDropdown()
        {
            IWebElement? state = driver.FindElement(By.Id("Select1"));
            state?.Click();
            Log.Information("Clicked on State drop down");
        }

        [When(@"User will select a State")]
        public void WhenUserWillSelectAState()
        {
            IWebElement? state = driver.FindElement(By.XPath("//*[@id=\"Select1\"]/option[17]"));
            state?.Click();
            Log.Information("Selected state");
        }

        [When(@"User will enter the '([^']*)' in the input")]
        public void WhenUserWillEnterTheInTheInput(string pincode)
        {
            IWebElement? pincodeInput = driver.FindElement(By.Name("postalCode"));
            pincodeInput?.SendKeys(pincode);
            pincodeInput?.SendKeys(Keys.Enter);
            Log.Information("Typed pincode");
        }

        [When(@"User will enter the '([^']*)' in the input box")]
        public void WhenUserWillEnterTheInTheInputBox(string phonenumber)
        {
            IWebElement? phonenumberInput = driver.FindElement(By.Name("phone"));
            phonenumberInput?.SendKeys(phonenumber);
            phonenumberInput?.SendKeys(Keys.Enter);
            Log.Information("Typed phone number");
        }
        [Then(@"The User will be on the Check out page")]
        public void ThenTheUserWillBeOnTheCheckOutPage()
        {
            TakeScreenShot(driver);
            try
            {
                Assert.That(driver.Url.Contains("checkouts"));
                LogTestResult("CheckOut Page Test", "CheckOut Page Test success");
            }
            catch (AssertionException ex)
            {
                LogTestResult("CheckOut Page Test", "CheckOut Page Test Failed", ex.Message);
            }
        }


    }
}
