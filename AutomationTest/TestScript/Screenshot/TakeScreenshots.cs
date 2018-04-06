using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using AutomationTest.ComponentHelper;
using AutomationTest.Settings;




namespace AutomationTest.TestScript.Screenshot
{
    [TestClass]
    public class TakeScreenshots
    {
        [TestMethod]
        public void ScreenShot()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            Helper.Click(By.LinkText("File a Bug"));
            Helper.Text(By.Id("Bugzilla_login"), ObjectRepository.Config.GetUsername());
            Helper.Text(By.Id("Bugzilla_password"), ObjectRepository.Config.GetPassword());
            GenericHelper.TakeScreenShot();
            GenericHelper.TakeScreenShot("Test.jpeg");


        }
    }
   
}
