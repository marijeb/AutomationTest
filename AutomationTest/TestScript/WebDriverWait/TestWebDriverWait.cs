using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutomationTest.ComponentHelper;
using AutomationTest.Settings;
using OpenQA.Selenium;

namespace AutomationTest.TestScript.WebDriverWait
{
    [TestClass]
    public class TestWebDriverWait
    {
        [TestMethod]
        public void TestWait()
        {
            NavigationHelper.NavigateToUrl("https://www.udemy.com/courses/");
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = (TimeSpan.FromSeconds(50));
            TextBoxHelper.TypeInTextBox(By.Name("q"),"C#");
        }
    }

}
