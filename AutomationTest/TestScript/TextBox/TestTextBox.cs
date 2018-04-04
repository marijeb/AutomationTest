using AutomationTest.ComponentHelper;
using AutomationTest.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace AutomationTest.TestScript.TextBox
{
    [TestClass]
    public class TestTextBox
    {
        [TestMethod]
        public void TextBox()
        {
            Helper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            Helper.Click(By.LinkText("File a Bug"));
            //IWebElement ele = ObjectRepository.Driver.FindElement(By.Id("Bugzilla_login"));
            //ele.SendKeys(ObjectRepository.Config.GetUsername());
            //ele = ObjectRepository.Driver.FindElement(By.Id("Bugzilla_password"));
            //ele.SendKeys(ObjectRepository.Config.GetPassword());
            //ele = ObjectRepository.Driver.FindElement(By.Id("Bugzilla_login"));
            //ele.Clear();
            Helper.Text(By.Id("Bugzilla_login"), ObjectRepository.Config.GetUsername());
            Helper.Text(By.Id("Bugzilla_password"), ObjectRepository.Config.GetPassword());
            Helper.Clear(By.Id("Bugzilla_login"));

        }

    }
}
