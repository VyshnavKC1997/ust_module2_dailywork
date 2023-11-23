using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5_POM.PageObject
{
    internal class NaaptolHomePage
    {
        IWebDriver driver;
        public NaaptolHomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How =How.Id,Using ="header_search_text")]
        public IWebElement SearchBox { get; set; }

        public void SearchTextInSearchBox(string searchText)
        {
            SearchBox.SendKeys(searchText);

        }
        public void SearchTextInput()
        {
            SearchBox.SendKeys(Keys.Enter);
        }
    }
}
