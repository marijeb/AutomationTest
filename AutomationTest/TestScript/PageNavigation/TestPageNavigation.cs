using AutomationTest.ComponentHelper;
using AutomationTest.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AutomationTest.TestScript.PageNavigation
{
    [TestClass]
    public class TestPageNavigation
    {
        [TestMethod]
        public void OpenPage()
        {
            Helper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            Console.WriteLine("Title of page: {0}", Helper.GetTitle());
        }
    }
}
