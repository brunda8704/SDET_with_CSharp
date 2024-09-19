using BDD_PetStore.Hooks;
using BDD_PetStore.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Serilog;
using System;
using System.Security.Cryptography;
using TechTalk.SpecFlow;

namespace BDD_PetStore.Steps
{
    [Binding]
    public class SearchAndAddToCartSteps : CoreCodes
    {
        IWebDriver? driver = AllHooks.driver;

        [When(@"User will type the '([^']*)' in the search box")]
        public void WhenUserWillTypeTheInTheSearchBox(string searchtext)
        {
            AllHooks.test = AllHooks.extent.CreateTest("Search Product and Add to Cart Test");

            Log.Information("Search Product and Add to Cart Test Started");
            AllHooks.test.Info("Search Product and Add to Cart Test Started");

            Log.Information("JPetStore Home Page Loaded Successfully");
            AllHooks.test.Info("JPetStore Home Page Loaded Successfully");

            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromSeconds(5);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(50);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            fluentWait.Message = "Element not found";

            IWebElement? searchInput = fluentWait.Until(d=>d.FindElement(By.Name("keyword")));
            searchInput?.SendKeys(searchtext);
            Log.Information("Typed search text " + searchtext);
            AllHooks.test.Info("Typed search text " + searchtext);

            TakeScreenShot(driver);
            var ss = ((ITakesScreenshot)driver).GetScreenshot().AsBase64EncodedString;
            AllHooks.test.AddScreenCaptureFromBase64String(ss);
            searchInput?.SendKeys(Keys.Enter);
        }

        [Then(@"List of available products will appear")]
        public void ThenListOfAvailableProductsWillAppear()
        {
            TakeScreenShot(driver);
            try
            {
                Log.Information("Product Lists Page Loaded Successfully");
                AllHooks.test.Info("Product Lists Page Loaded Successfully");

                Assert.That(driver.Title, Does.Contain("JPetStore Demo"));

                Log.Information("JPetStore Demo Title Checked");
                AllHooks.test.Info("JPetStore Demo Title Checked");

                var ss = ((ITakesScreenshot)driver).GetScreenshot().AsBase64EncodedString;
                AllHooks.test.AddScreenCaptureFromBase64String(ss);
            }
            catch (AssertionException ex)
            {
                Log.Error("JPetStore Demo Title Check Failed",ex.Message);
                var ss = ((ITakesScreenshot)driver).GetScreenshot().AsBase64EncodedString;
                AllHooks.test.AddScreenCaptureFromBase64String(ss);
                AllHooks.test.Info("JPetStore Demo Title Check Failed");
            }
        }

        [When(@"User will click on product '([^']*)'")]
        public void WhenUserWillClickOnProduct(string productId)
        {
            string path = "//a[@href='/actions/Catalog.action?viewProduct=&productId=" + productId + "']";
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromSeconds(5);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(50);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            fluentWait.Message = "Element not found";

            IWebElement? product = fluentWait.Until(d => d.FindElement(By.XPath(path)));
            product.Click();
            Log.Information("Clicked on product with productId " + productId);
            AllHooks.test.Info("Clicked on product with productId " + productId);
        }

        [Then(@"Product page will appear")]
        public void ThenProductPageWillAppear()
        {
            
            try
            {
                Log.Information("Product Page Loaded Successfully");
                AllHooks.test.Info("Product Page Loaded Successfully");

                TakeScreenShot(driver);
                string? goldfish = driver.FindElement(By.XPath("//*[@id=\"Catalog\"]/h2")).Text;
                Assert.AreEqual(goldfish, "Goldfish");

                Log.Information("Product Goldfish Heading Checked");
                AllHooks.test.Info("Product Goldfish Heading Checked");

                var ss = ((ITakesScreenshot)driver).GetScreenshot().AsBase64EncodedString;
                AllHooks.test.AddScreenCaptureFromBase64String(ss);
            }
            catch (AssertionException ex)
            {
                Log.Error("Product Goldfish Heading Check Failed", ex.Message);
                var ss = ((ITakesScreenshot)driver).GetScreenshot().AsBase64EncodedString;
                AllHooks.test.AddScreenCaptureFromBase64String(ss);
                AllHooks.test.Info("Product Goldfish Heading Check Failed");
            }
        }

        [When(@"User will click on add to cart button of item '([^']*)'")]
        public void WhenUserWillClickOnAddToCartButtonOfItem(string itemId)
        {
            string path = "//a[@href='/actions/Cart.action?addItemToCart=&workingItemId=" + itemId+ "']";
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromSeconds(5);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(50);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            fluentWait.Message = "Element not found";

            IWebElement? addToCart = fluentWait.Until(d => d.FindElement(By.XPath(path)));
            addToCart.Click();
            Log.Information("Clicked on add to cart button of item with itemId " + itemId);
            AllHooks.test.Info("Clicked on add to cart button of item with itemId " + itemId);
        }

        [Then(@"Shopping Cart page will appear")]
        public void ThenShoppingCartPageWillAppear()
        {
            
            try
            {
                Log.Information("Shopping Cart Page Loaded Successfully");
                AllHooks.test.Info("Shopping Cart Page Loaded Successfully");

                TakeScreenShot(driver);
                string? shoppingCart = driver.FindElement(By.XPath("//*[@id=\"Cart\"]/h2")).Text;
                Assert.AreEqual(shoppingCart,"Shopping Cart");

                Log.Information("Shopping Cart Heading Checked");
                AllHooks.test.Info("Shopping Cart Heading Checked");

                LogTestResult("Search Product and Add to Cart Test", "Search Product and Add to Cart Test Success");
                var ss = ((ITakesScreenshot)driver).GetScreenshot().AsBase64EncodedString;
                AllHooks.test.AddScreenCaptureFromBase64String(ss);

            }
            catch (AssertionException ex)
            {
                Log.Error("Shopping Cart Heading Check Failed", ex.Message);
                LogTestResult("Search Product and Add to Cart Test", "Search Product and Add to Cart Test Failed",ex.Message);
                var ss = ((ITakesScreenshot)driver).GetScreenshot().AsBase64EncodedString;
                AllHooks.test.AddScreenCaptureFromBase64String(ss);
                AllHooks.test.Info("Shopping Cart Heading Check Failed");
            }
        }

    }
}
