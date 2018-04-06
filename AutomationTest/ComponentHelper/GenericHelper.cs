using AutomationTest.Settings;
using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Support.Extensions;
using System.Configuration;
using System.IO;

namespace AutomationTest.ComponentHelper
{
    public class GenericHelper
    {
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

        public static IWebElement GetElement(By Locator)
        {
            if (IsElementPresent(Locator))
                return ObjectRepository.Driver.FindElement(Locator);
            else
                throw new NoSuchElementException("Element not Found:" + Locator.ToString());
        }

        public static void TakeScreenShot(string filename = "Screenshot", string path = @"C:\temp\screenshot\")
        {
            // Check if folder temp exist, of not create folder
            if (!Directory.Exists(@"C:\temp\screenshot\"))
                Directory.CreateDirectory(@"C:\temp\screenshot\");

            Screenshot ss = ObjectRepository.Driver.TakeScreenshot();
            if (filename.Equals("Screenshot"))
            {
                filename = filename + DateTime.UtcNow.ToString("yyyy-MM-dd-mm-ss") +".jpeg";
                ss.SaveAsFile(@path + filename,ScreenshotImageFormat.Jpeg);
                return;
            }
            ss.SaveAsFile(@path + filename,ScreenshotImageFormat.Jpeg);

        }

    }
}
