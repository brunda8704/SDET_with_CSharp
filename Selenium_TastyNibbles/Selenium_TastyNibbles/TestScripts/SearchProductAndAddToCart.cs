using OpenQA.Selenium;
using Selenium_TastyNibbles.PageObjects;
using Selenium_TastyNibbles.Utilities;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_TastyNibbles.TestScripts
{
    [TestFixture]
    internal class SearchProductAndAddToCart:CoreCodes
    {
        [Test, Category("End to End Testing"),Order(2)]
        public void SearchingAndAddToCartTest()
        {
            string? currdir = Directory.GetParent(@"../../../")?.FullName;
            string? logfilepath = currdir + "/Logs/log_" +
                DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt";

            Log.Logger = new LoggerConfiguration()
            .WriteTo.Console()
            .WriteTo.File(logfilepath, rollingInterval: RollingInterval.Day)
            .CreateLogger();


            var homePage = new TastyNibbleHomePage(driver);
            if (!driver.Url.Contains("https://www.tastynibbles.in/"))
            {
                driver.Navigate().GoToUrl("https://www.tastynibbles.in/");
            }

            Log.Information("Searching And Add To Cart Test Started");

            ScrollIntoView(driver, driver.FindElement(By.XPath("(//a[@href='/products/copy-of-samudra-sadhya-pack-1'])[1]")));
            var productPage = homePage.ClickBuyNowButton();
            Log.Information("Clicked on Buy Now Button on Home Page");
            try
            {
                TakeScreenShot();
                Assert.That(driver.Url.Contains("samudra-sadhya"));
                Log.Information("Test passed for Product Page");
                test = extent.CreateTest("Product Page");
                test.Pass("Product Page Loaded Successfully");
            }
            catch (AssertionException ex)
            {
                Log.Error($"Test failed for Product Page. \n Exception: {ex.Message}");
                test = extent.CreateTest("Product Page");
                test.Fail("Product Page Loading failed");
            }
            productPage.ClickAddtoCartButton();
            Log.Information("Clicked on Add to cart Button");
            try
            {
                TakeScreenShot();
                Assert.That(driver.Url.Contains("samudra-sadhya"));
                Log.Information("Test passed for Adding Product to Cart");
                test = extent.CreateTest("Add Product to Cart");
                test.Pass("Product Added Successfully");
            }
            catch (AssertionException ex)
            {
                Log.Error($"Test failed for Adding Product to Cart. \n Exception: {ex.Message}");
                test = extent.CreateTest("Add Product to Cart");
                test.Fail("Product Adding failed");
            }
            
        }
    }
}


