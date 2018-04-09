using System;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutomationTest.ComponentHelper;
using AutomationTest.Settings;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

namespace AutomationTest.TestScript.FindElements
{
    [TestClass]
    public class HandleElements
    {
        [TestMethod]
        public void GetAllElements()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            IReadOnlyCollection<IWebElement> elements =  ObjectRepository.Driver.FindElements(By.XPath("//input"));
            IReadOnlyCollection<IWebElement> elements2 = ObjectRepository.Driver.FindElements(By.Id("123"));
            foreach(var ele in elements)
            {
                Console.WriteLine("ID: {0}", ele.GetAttribute("name"));
            }

        }
            

    }
}
