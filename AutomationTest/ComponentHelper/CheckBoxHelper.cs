using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting.Logging;

namespace AutomationTest.ComponentHelper
{
    public class CheckBoxHelper
    {
        private static IWebElement element;

        public static void CheckedCheckBox(By locator)
        {
            GenericHelper.GetElement(locator).Click();
        }

        public static bool IsChecked(By locator)
        {
            element = GenericHelper.GetElement(locator);
            element.Click();
            string flag = element.GetAttribute("checked");

            if (flag == null)
                return false;
            else
            {
                return flag.Equals("true") || flag.Equals("checked");

            }
        }
    }
}
