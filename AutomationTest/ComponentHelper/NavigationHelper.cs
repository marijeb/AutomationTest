using AutomationTest.Settings;

namespace AutomationTest.ComponentHelper
{
    public class NavigationHelper
    {
        public static void NavigateToUrl(string Url)
        {
            ObjectRepository.Driver.Navigate().GoToUrl(Url);
        }
    }
    
}
