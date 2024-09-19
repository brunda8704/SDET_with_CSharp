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
    internal class SearchProductAndAddToCartAndCheckOutTest:CoreCodes  //Inheritance
    {
        List<TastyNibbleData>? excelDataList;
       

        [Test, Category("End to End Testing"),Order(1)]
        public void UserSearchingAndAddToCartAndCheckOutTest()
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

            Log.Information("User Searching And Add To Cart And Check Out Test Started");

            //Data Driven Testing
            string? currDir = Directory.GetParent(@"../../../")?.FullName;
            string? excelFilePath = currDir + "/TestData/InputData.xlsx";
            string? sheetName = "TastyNibbleData";

            excelDataList = TastyNibbleUtils.ReadExcelData(excelFilePath, sheetName);
            foreach (var excelData in excelDataList)
            {
                string? searchinput = excelData?.SearchInput;
                Console.WriteLine($"Search Input: {searchinput}");
                homePage.ClickSearchInput(searchinput);
                Log.Information("Typed search input");

                var searchedProductPage = homePage.ClickSearchButton();
                Log.Information("Clicked on Search button");
                try
                {
                    TakeScreenShot();
                    Assert.That(driver.Url.Contains("Ghee"));
                    Log.Information("Test passed for Searched Product List Page");
                    test = extent.CreateTest("Searched Product List Page");
                    test.Pass("Searched Product List Page Loaded Successfully");
                }
                catch (AssertionException ex)
                {
                    Log.Error($"Test failed for Searched Product List Page. \n Exception: {ex.Message}");
                    test = extent.CreateTest("Searched Product List Page");
                    test.Fail("Searched Product List Page Loading failed");
                }
                var productPage = searchedProductPage.ClickGheeRice();
                Log.Information("Clicked on Ghee Rice");
                try
                {
                    TakeScreenShot();
                    Assert.That(driver.Url.Contains("ghee-rice"));
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
                productPage.ClickSize();
                Log.Information("Clicked on Size");
                productPage.ClickAddtoCartButton();
                Log.Information("Clicked on Add to cart button");
                var paymentPage = productPage.ClickCheckoutButton();
                Log.Information("Clicked on Checkout button");
                try
                {
                    TakeScreenShot();
                    Assert.That(driver.Url.Contains("checkouts"));
                    Log.Information("Test passed for Payment Page");
                    test = extent.CreateTest("Payment Page");
                    test.Pass("Payment Page Loaded Successfully");
                }
                catch (AssertionException ex)
                {
                    Log.Error($"Test failed for Payment Page. \n Exception: {ex.Message}");
                    test = extent.CreateTest("Payment Page");
                    test.Fail("Payment Page Loading failed");
                }


                string? email = excelData?.Email;
                Console.WriteLine($"Email: {email}");
                paymentPage.ClickContactInput(email);
                Log.Information("Typed Email");


                string? firstname = excelData?.FirstName;
                Console.WriteLine($"First Name: {firstname}");
                paymentPage.ClickFirstNameInput(firstname);
                Log.Information("Typed First Name");

                string? lastname = excelData?.LastName;
                Console.WriteLine($"Last Name: {lastname}");
                paymentPage.ClickLastNameInput(lastname);
                Log.Information("Typed last Name");

                string? address = excelData?.Address;
                Console.WriteLine($"Address: {address}");
                paymentPage.ClickAddressInput(address);
                Log.Information("Typed Address");

                string? city = excelData?.City;
                Console.WriteLine($"City: {city}");
                paymentPage.ClickCityInput(city);
                Log.Information("Typed City");

                paymentPage.ClickStateDropdown();
                Log.Information("Clicked State Drop Down");
                paymentPage.ClickParticularState();
                Log.Information("Selected State");

                string? pincode = excelData?.Pincode;
                Console.WriteLine($"Pincode: {pincode}");
                paymentPage.ClickPincodeInput(pincode);
                Log.Information("Typed Pincode");

                string? phonenumber = excelData?.PhoneNumber;
                Console.WriteLine($"Phone number: {phonenumber}");
                paymentPage.ClickPhoneNumberInput(phonenumber);
                Log.Information("Typed PhoneNumber");

                try
                {
                    TakeScreenShot();
                    Assert.That(driver.Url.Contains("checkouts"));
                    Log.Information("Test passed for Customer Details");
                    test = extent.CreateTest("Customer Details Page");
                    test.Pass("Customer Details entered Successfully");
                }
                catch (AssertionException ex)
                {
                    Log.Error($"Test failed for Customer Details. \n Exception: {ex.Message}");
                    test = extent.CreateTest("Customer Details");
                    test.Fail("Customer Details entering failed");
                }



            }
        }
    }
}
