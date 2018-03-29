using AutomationTest.Settings;

namespace AutomationTest.ComponentHelper
{
    public class WindowHelper
    {
        public static string GetTitle()
        {
            return ObjectRepository.Driver.Title;
        }
    }
}
