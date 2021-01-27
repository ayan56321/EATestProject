using System;
using System.Collections.Generic;
using System.Linq;
using EAAutoFramework.Base;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace EAAutoFramework.Extensions
{
    public static class WebElementExtensions
    {


        public static void SelectDDL(this IWebElement element, string value)
        {
            SelectElement ddl = new SelectElement(element);
            ddl.SelectByText(value);
        }

        public static void Hover(this IWebElement element)
        {
            Actions action = new Actions(DriverContext.Driver);
            action.MoveToElement(element).Perform();
        }

        public static void HoverAndClick(this IWebElement elementToHover, IWebElement elementToClick)
        {
            Actions action = new Actions(DriverContext.Driver);
            action.MoveToElement(elementToHover).Click(elementToClick).Build().Perform();
        }

        public static string GetText(IWebElement element)
        {
            return element.Text;
        }


        public static string GetSelectedDropDown(IWebElement element)
        {
            SelectElement ddl = new SelectElement(element);
            return ddl.AllSelectedOptions.First().ToString();
        }


        public static IList<IWebElement> GetSelectedListOptions(IWebElement element)
        {
            SelectElement ddl = new SelectElement(element);
            return ddl.AllSelectedOptions;
        }


        /// <summary>
        /// Check if the element exist
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        private static bool IsElementPresent(IWebElement element)
        {
            try
            {
                bool b = element.Displayed;
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Assert if the Element is present
        /// </summary>
        /// <param name="element"></param>
        public static void AssertElementPresent(this IWebElement element)
        {
            if (!IsElementPresent(element))
                throw new AssertionException(String.Format("AssertElementNotPresent exception"));
        }

        public static string getLinkText(this IWebElement element)
        {
            return element.Text;
        }
    }
}
