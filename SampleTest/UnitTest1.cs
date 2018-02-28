using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SampleTest
{
    [TestClass]
    public class UnitTest1
    {
        

        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = null;
            try
            {
                Console.WriteLine("Test Started!!!");
                driver = new ChromeDriver(@"C:\CodeBase\SampleTest\SampleTest\bin\Debug\netcoreapp2.0\");
                driver.Manage().Window.Maximize();
                SearchEngineHomePage googlepage = new SearchEngineHomePage(driver);
               GoogleNews gnInstance= googlepage.setSearchTextAndGetResult();
                gnInstance.click();

            }
            catch(Exception e)
            {

            }
            finally
            {
                driver.Close();
                Console.WriteLine("Test Completed!!!");
            }
        }
    }
}
