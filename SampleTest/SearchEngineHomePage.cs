using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Support.PageObjects;
namespace SampleTest
{
    public class SearchEngineHomePage:BasePage
    {
       
        private readonly string url = @"http://www.google.com";

        public SearchEngineHomePage(IWebDriver browser):base(browser)
        {

            driver.Navigate().GoToUrl("http://google.com");
        }

        public GoogleNews setSearchTextAndGetResult()
        {
            IWebElement element = driver.FindElement(By.Id("lst-ib"));
            element.SendKeys("World Economics");
            element.SendKeys(Keys.Enter);
            return new GoogleNews(driver);

        }

        public GoogleNews getNewsInstance()
        {
            return null;
        }
    }
}
