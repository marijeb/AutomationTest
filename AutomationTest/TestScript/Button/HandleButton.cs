using AutomationTest.ComponentHelper;
using AutomationTest.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;

namespace AutomationTest.TestScript.Button
{
    [TestClass]
    public class HandleButton
    {
        [TestMethod]
        public void TestButton()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            Helper.Click(By.LinkText("File a Bug"));
            Helper.Text(By.Id("Bugzilla_login"), ObjectRepository.Config.GetUsername());
            Helper.Text(By.Id("Bugzilla_password"), ObjectRepository.Config.GetPassword());
            //ObjectRepository.Driver.FindElement(By.Id("log_in")).Click();
            Console.WriteLine("Enables: {0}", ButtonHelper.IsButtonEnabled(By.Id("log_in")));
            Console.WriteLine("Button Text: {0}", ButtonHelper.GetButtonText(By.Id("log_in")));
            ButtonHelper.ClickButton(By.Id("log_in"));
            Console.WriteLine("Page: {0}", Helper.GetTitle());


        }
    }
}
