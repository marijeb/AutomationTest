﻿using System;
using AutomationTest.Settings;
using OpenQA.Selenium;

// merged all the helper classes in 1 helper class

namespace AutomationTest.ComponentHelper
{
    public class Helper
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
        public static string GetTitle()
        {
            return ObjectRepository.Driver.Title;
        }
        public static void NavigateToUrl(string Url)
        {
            ObjectRepository.Driver.Navigate().GoToUrl(Url);
        }
        public static void Text(By locator, string text)
        {
            GetElement(locator).SendKeys(text);
        }

        public static void Clear(By locator)
        {
            GetElement(locator).Clear();
        }

        public static void Click(By locator)
        {
            GetElement(locator).Click();
        }

        private static IWebElement element;
        public static void CheckedCheckBox(By locator)
        {
            GetElement(locator).Click();

        }

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
    }
}
