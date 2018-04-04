using AutomationTest.ComponentHelper;
using AutomationTest.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;

namespace AutomationTest.TestScript.CheckBox
{
    [TestClass]
    public class TestCheckBox
    {
        [TestMethod]
        public void CheckBox()
        {
            Helper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            Helper.Click(By.LinkText("File a Bug"));
            Helper.Text(By.Id("Bugzilla_login"), ObjectRepository.Config.GetUsername());
            Helper.Text(By.Id("Bugzilla_password"), ObjectRepository.Config.GetPassword());
            //Helper.Clear(By.Id("Bugzilla_login"));
            //ObjectRepository.Driver.FindElement(By.Id("Bugzilla_restrictlogin")).Click();
            Console.WriteLine(Helper.IsChecked(By.Id("Bugzilla_restrictlogin")));
            Helper.CheckedCheckBox(By.Id("Bugzilla_restrictlogin"));
            Console.WriteLine(Helper.IsChecked(By.Id("Bugzilla_restrictlogin")));
        }
    }
}
