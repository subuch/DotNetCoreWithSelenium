using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleTest
{
    public class BasePage
    {
        public readonly IWebDriver driver=null;

        public BasePage(IWebDriver browser)
        {
            this.driver = browser;
            
        }
    }
}
