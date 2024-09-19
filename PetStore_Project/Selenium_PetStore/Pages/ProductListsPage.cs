using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_PetStore.Pages
{
    internal class ProductListsPage
    {
        IWebDriver? driver;
        public ProductListsPage(IWebDriver? driver)
        {
            this.driver = driver ?? throw new ArgumentException(nameof(driver));
            PageFactory.InitElements(driver, this);
        }

        //Arrange
        [FindsBy(How = How.XPath, Using = "//a[@href='/actions/Catalog.action?viewProduct=&productId=FI-FW-02']")]
        private IWebElement? Product { get; set; }

        //Act
        public ProductPage ClickProduct()
        {
            Product?.Click();
            return new ProductPage(driver);
        }
    }
}
