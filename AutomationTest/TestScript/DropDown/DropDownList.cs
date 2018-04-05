using System;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutomationTest.ComponentHelper;
using AutomationTest.Settings;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

namespace AutomationTest.TestScript.DropDown
{
    //used different path as user has no admin rights and therefore cannot get to page reference in course
    [TestClass]
    public class DropDownList
    {
        [TestMethod]
        public void TestList()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            Helper.Click(By.LinkText("Search"));
            Helper.Click(By.Id("tab_specific"));
            //IWebElement element = ObjectRepository.Driver.FindElement(By.Id("bug_status"));
            //SelectElement select = new SelectElement(element);
            //select.SelectByIndex(0);
            //select.SelectByValue("__closed__");
            //select.SelectByText("All");
            //Console.WriteLine("Selected value: {0}", select.SelectedOption.Text);
            //IList<IWebElement> list = select.Options;
            //foreach (IWebElement ele in list)
            //{
            //    Console.WriteLine("Value: {0}, Text: {1}", ele.GetAttribute("value"), ele.Text);
            //}
            DropDrownHelper.SelectElement(By.Id("bug_status"), 1);
            DropDrownHelper.SelectElement(By.Id("bug_status"), "All");
            foreach (string str in DropDrownHelper.GetAllItem(By.Id("bug_status")))
            {
                Console.WriteLine("Text: {0}", str);
            }

        }
    }

}
