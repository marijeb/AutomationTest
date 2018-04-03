using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutomationTest.Settings;
using OpenQA.Selenium;
using AutomationTest.ComponentHelper;
using System;

namespace AutomationTest.TestScript.Hyperlink
{
    [TestClass]
    public class TestHyperLink
    {
        [TestMethod]
        public void ClickLink()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            //IWebElement element = ObjectRepository.Driver.FindElement(By.LinkText("File a Bug"));
            //element.Click();
            
            //IWebElement pelement = ObjectRepository.Driver.FindElement(By.PartialLinkText("File"));
            //pelement.Click();
            LinkHelper.ClickLink(By.LinkText("File a Bug"));
            LinkHelper.ClickLink(By.PartialLinkText("Bug"));

        }
    }
}
