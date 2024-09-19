using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Selenium_PetStore.Helpers;
using Selenium_PetStore.Pages;
using Selenium_PetStore.Utils;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_PetStore.Tests
{
    [TestFixture]
    internal class AddToCartTests:CoreCodes
    {
        List<ProductData>? excelDataList;
        [Test]
        [Category("End to End Testing")]
        public void UserSearchProductAndAddToCartTest()
        {

            string? currdir = Directory.GetParent(@"../../../")?.FullName;
            string? logfilepath = currdir + "/Logs/log_" +
                DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt";

            test = extent.CreateTest("Search Product and Add to Cart Test");

            Log.Logger = new LoggerConfiguration()
            .WriteTo.Console()
            .WriteTo.File(logfilepath, rollingInterval: RollingInterval.Day)
            .CreateLogger();

            var homePage = new HomePage(driver);
            if (!driver.Url.Contains("https://petstore.octoperf.com/actions/Catalog.action"))
            {
                driver.Navigate().GoToUrl("https://petstore.octoperf.com/actions/Catalog.action");
            }

            Log.Information("Search Product and Add to Cart Test Started");
            test.Info("Search Product and Add to Cart Test Started");

            Log.Information("JPetStore Home Page Loaded Successfully");
            test.Info("JPetStore Home Page Loaded Successfully");

            TakeScreenShot();
            var ss = ((ITakesScreenshot)driver).GetScreenshot().AsBase64EncodedString;
            test.AddScreenCaptureFromBase64String(ss);

            //Data Driven Testing
            string? currDir = Directory.GetParent(@"../../../")?.FullName;
            string? excelFilePath = currDir + "/TestData/InputData.xlsx";
            string? sheetName = "Product";

            excelDataList = ProductUtils.ReadExcelData(excelFilePath, sheetName);
            foreach (var excelData in excelDataList)
            {
                string? searchtext = excelData?.SearchText;
                homePage.ClickSearchInput(searchtext);
                TakeScreenShot();
                Log.Information("Typed search text " +searchtext);
                test.Info("Typed search text " + searchtext);
            }

            try
            {
                Log.Information("Product Lists Page Loaded Successfully");
                test.Info("Product Lists Page Loaded Successfully");

                TakeScreenShot();
                Assert.That(driver.Title, Does.Contain("JPetStore Demo"));

                Log.Information("JPetStore Demo Title Checked");
                test.Info("JPetStore Demo Title Checked");

                var s = ((ITakesScreenshot)driver).GetScreenshot().AsBase64EncodedString;
                test.AddScreenCaptureFromBase64String(s);

                ProductListsPage productListsPage = new ProductListsPage(driver);
                var productPage=productListsPage.ClickProduct();

                Log.Information("Clicked on product");
                test.Info("Clicked on product");

                Log.Information("Product Page Loaded Successfully");
                test.Info("Product Page Loaded Successfully");

                TakeScreenShot();
                string? goldfish = driver.FindElement(By.XPath("//*[@id=\"Catalog\"]/h2")).Text;
                Assert.That("Goldfish",Is.EqualTo(goldfish));

                Log.Information("Product Goldfish Heading Checked");
                test.Info("Product Goldfish Heading Checked");

                var sss = ((ITakesScreenshot)driver).GetScreenshot().AsBase64EncodedString;
                test.AddScreenCaptureFromBase64String(sss);

                productPage.ClickAddToCart();
                Log.Information("Clicked on add to cart button");
                test.Info("Clicked on add to cart button");

                Log.Information("Shopping Cart Page Loaded Successfully");
                test.Info("Shopping Cart Page Loaded Successfully");

                TakeScreenShot();
                string? shoppingCart = driver.FindElement(By.XPath("//*[@id=\"Cart\"]/h2")).Text;
                Assert.That("Shopping Cart", Is.EqualTo(shoppingCart));

                Log.Information("Shopping Cart Heading Checked");
                test.Info("Shopping Cart Heading Checked");

                var screenshot = ((ITakesScreenshot)driver).GetScreenshot().AsBase64EncodedString;
                test.AddScreenCaptureFromBase64String(screenshot);

                test.Pass("Search Product and Add to Cart Test Passed");
                Log.Information("Search Product and Add to Cart Test Passed");

            }
            catch(AssertionException ex)
            {
                Log.Error($"Test failed for Search Product and Add to Cart Test. \n Exception: {ex.Message}");
                test.Info("Test failed for Search Product and Add to Cart Test");
                test.Fail("Search Product and Add to Cart Test Failed");
            } 
        }

    }
}
