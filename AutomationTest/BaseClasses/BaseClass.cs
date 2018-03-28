using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutomationTest.Settings;
using AutomationTest.Configuration;
using AutomationTest.CustomException;

namespace AutomationTest.BaseClasses
{
    [TestClass]
    public class BaseClass
    {
        private static IWebDriver GetFireFoxDriver()
        {
            IWebDriver driver = new FirefoxDriver();
            return driver;
        }

        private static IWebDriver GetChromeDriver()
        {
            IWebDriver driver = new ChromeDriver();
            return driver;

        }

        private static IWebDriver GetIEDriver()
        {
            IWebDriver driver = new InternetExplorerDriver();
            return driver;
        }

        [AssemblyInitialize]
        public static void InitWebdriver(TestContext tc)
        {
            ObjectRepository.Config = new AppConfigReader();

            switch (ObjectRepository.Config.GetBrowser())
            {
                case BrowserType.FireFox:
                    ObjectRepository.Driver = GetFireFoxDriver();
                    break;
                case BrowserType.Chrome:
                    ObjectRepository.Driver = GetChromeDriver();
                    break;
                case BrowserType.IExplorer:
                    ObjectRepository.Driver = GetIEDriver();
                    break;
                default:
                    throw new NoSuitableDriverFound("Driver not found : " + ObjectRepository.Config.GetBrowser().ToString());
            }
        }
    }
}

