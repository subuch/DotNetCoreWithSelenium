using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleTest
{
    public class GoogleNews:BasePage
    {
        public GoogleNews(IWebDriver browser) :base(browser)
        {

        }
        public void click()
        {
            IWebElement element = driver.FindElement(By.LinkText("News"));            
            element.SendKeys(Keys.Enter);

            IWebElement element1 = driver.FindElement(By.LinkText("Images"));
            element1.SendKeys(Keys.Enter);
            
            IWebElement element3 = driver.FindElement(By.LinkText("Videos"));
            element3.SendKeys(Keys.Enter);

            IWebElement element2 = driver.FindElement(By.LinkText("Maps"));
            element2.SendKeys(Keys.Enter);

        }
    }
}
