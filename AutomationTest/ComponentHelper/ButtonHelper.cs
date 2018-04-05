using OpenQA.Selenium;
using System;

namespace AutomationTest.ComponentHelper
{
    public class ButtonHelper
    {
        private static IWebElement element;

        public static void ClickButton(By locator)
        {
            element = Helper.GetElement(locator);
            element.Click();
        }

        public static bool IsButtonEnabled(By locator)
        {
            element = Helper.GetElement(locator);
            return element.Enabled;
        }

        public static string GetButtonText(By locator)
        {
            element = Helper.GetElement(locator);
            if (element.GetAttribute("value") == null)
                    return string.Empty;
            return element.GetAttribute("value");
        }

    }
}
