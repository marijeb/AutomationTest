using System;
using AutomationTest.Settings;
using OpenQA.Selenium;
using System.IO;
using OpenQA.Selenium.Support.Extensions;

// merged all the helper classes in 1 helper class

namespace AutomationTest.ComponentHelper
{
    public class Helper
    {
        private static IWebElement element;

        // Is Element present on Page
        public static bool IsElementPresent(By Locator)
        {
            try
            {
                return ObjectRepository.Driver.FindElements(Locator).Count == 1;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Go to Element
        public static IWebElement GetElement(By Locator)
        {
            if (IsElementPresent(Locator))
                return ObjectRepository.Driver.FindElement(Locator);
            else
                throw new NoSuchElementException("Element not Found:" + Locator.ToString());
        }

        // Get page title
        public static string GetTitle()
        {
            return ObjectRepository.Driver.Title;
        }

        // Navigate to URL
        public static void NavigateToUrl(string Url)
        {
            ObjectRepository.Driver.Navigate().GoToUrl(Url);
        }

        //Enter text
        public static void Text(By locator, string text)
        {
            GetElement(locator).SendKeys(text);
        }

        // Clear enter value
        public static void Clear(By locator)
        {
            GetElement(locator).Clear();
        }

        //Click button, link etc
        public static void Click(By locator)
        {
            GetElement(locator).Click();
        }

       
        public static void CheckedCheckBox(By locator)
        {
            GetElement(locator).Click();

        }
        // Check if button is selected 
        public static bool IsChecked(By locator)
        {
            element = GetElement(locator);
            element.Click();
            string flag = element.GetAttribute("checked");

            if (flag == null)
                   return false;
               else 
            {
                return flag.Equals("true") || flag.Equals("checked");

            }
        }

        // Check if Button is enabled
        public static bool IsButtonEnabled(By locator)
        {
            element = GetElement(locator);
            return element.Enabled;
        }

        // This method gets the value of the given attribute of the element
        public static string GetButtonText(By locator)
        {
            element = GetElement(locator);
            if (element.GetAttribute("value") == null)
                return string.Empty;
            return element.GetAttribute("value");
        }

        // This method will fetch the visible (i.e. not hidden by CSS) innerText of the element
        public static string GetRadioButtonText(By locator)
        {
            element = Helper.GetElement(locator);
            if (element.Text == null)
            {
                return string.Empty;
            }

            return element.Text;
        }
        // This method will take a screenshot and crate a folder if the folder is not present
        public static void TakeScreenShot(string filename = "Screenshot", string path = @"C:\temp\screenshot\")
        {
            // Check if folder temp exist, of not create folder
            if (!Directory.Exists(@"C:\temp\screenshot\"))
                Directory.CreateDirectory(@"C:\temp\screenshot\");

            Screenshot ss = ObjectRepository.Driver.TakeScreenshot();
            if (filename.Equals("Screenshot"))
            {
                filename = filename + DateTime.UtcNow.ToString("yyyy-MM-dd-mm-ss") + ".jpeg";
                ss.SaveAsFile(@path + filename, ScreenshotImageFormat.Jpeg);
                return;
            }
            ss.SaveAsFile(@path + filename, ScreenshotImageFormat.Jpeg);

        }
    }

}
