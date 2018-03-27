using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://bugzilla.mozilla.org/"); //this will open the web page
            driver.Close(); // this will close the browser session
            driver.Quit(); // this will stop the webdriver
        }

    }
}
