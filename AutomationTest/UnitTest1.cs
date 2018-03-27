using AutomationTest.Configuration;
using AutomationTest.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Configuration;

namespace AutomationTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IConfig config = new AppConfigReader();
            Console.WriteLine("Browser : {0}", config.GetBrowser());
            Console.WriteLine("Username : {0}", config.GetUsername());
            Console.WriteLine("Password : {0}", config.GetPassword());
        }

    }
}
