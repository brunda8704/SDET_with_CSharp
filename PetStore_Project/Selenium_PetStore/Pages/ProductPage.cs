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
    internal class ProductPage
    {
        IWebDriver? driver;
        public ProductPage(IWebDriver? driver)
        {
            this.driver = driver ?? throw new ArgumentException(nameof(driver));
            PageFactory.InitElements(driver, this);
        }

        //Arrange
        [FindsBy(How = How.XPath, Using = "//a[@href='/actions/Cart.action?addItemToCart=&workingItemId=EST-20']")]
        private IWebElement? AddToCart { get; set; }

        //Act
        public ShoppingCartPage ClickAddToCart()
        {
            AddToCart?.Click();
            return new ShoppingCartPage(driver);
        }
    }
}
