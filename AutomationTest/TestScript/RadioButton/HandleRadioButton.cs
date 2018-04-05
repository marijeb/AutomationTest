using AutomationTest.ComponentHelper;
using AutomationTest.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;

namespace AutomationTest.TestScript.RadioButton
{
    //used different website as user has no admin rights and therefore cannot get to page reference in course
    [TestClass]
    public class HandleRadioButton
    {
        [TestMethod]
        public void RadioButton()
        {
            NavigationHelper.NavigateToUrl("https://www-archive.mozilla.org/projects/ui/accessibility/unix/testcase/HTML/");
            Helper.Click(By.XPath("//div[@id='mainContent']/ul[@class='toc']//a[@href='#Radio_Button_Test_Cases']"));
            //IWebElement element = ObjectRepository.Driver.FindElement(By.Id("rbutton1"));
            //element.Click();
            //Helper.Click(By.Id("rbutton1"));
            Console.WriteLine("Selected: {0}", Helper.IsChecked(By.Id("rbutton1")));
           //IWebElement webelemt = ObjectRepository.Driver.FindElement(By.XPath("//label[.='RadioButton1']"));
           //Console.WriteLine("Radio Button Text: {0}", webelemt.Text);
           Console.WriteLine("Text: {0}", Helper.GetRadioButtonText(By.XPath("//label[@for='rbutton1']")));
           Helper.Click(By.Id("rbutton1"));
            
        }
    }
}
