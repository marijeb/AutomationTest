using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Linq;

namespace AutomationTest.ComponentHelper
{
    public class DropDrownHelper
    {
        private static SelectElement select;

        public static void SelectElement(By locator, int index)
        {
            select = new SelectElement(Helper.GetElement(locator));
            select.SelectByIndex(index);
        }

        public static void SelectElement(By locator, string visibletext)
        {
            select = new SelectElement(Helper.GetElement(locator));
            select.SelectByText(visibletext);
        }
        public static IList<string> GetAllItem(By locator)
        {
            select = new SelectElement(Helper.GetElement(locator));
            return select.Options.Select((x) => x.Text).ToList();
        }

    }

}
