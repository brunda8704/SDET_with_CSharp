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
    internal class HomePage
    {
        IWebDriver? driver;
        public HomePage(IWebDriver? driver)
        {
            this.driver = driver ?? throw new ArgumentException(nameof(driver));
            PageFactory.InitElements(driver, this);
        }

        //Arrange
        [FindsBy(How = How.Name, Using = "keyword")]
        private IWebElement? SearchInput { get; set; }

        //Act
        public ProductListsPage ClickSearchInput(string searchtext)
        {   
            SearchInput?.Click();
            SearchInput?.SendKeys(searchtext);
            SearchInput?.SendKeys(Keys.Enter);
            return new ProductListsPage(driver);
        }
    }
}
