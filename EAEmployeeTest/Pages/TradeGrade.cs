using EAAutoFramework.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EAEmployeeTest.Pages
{
    public class TradeGrade : BasePage
    {

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Enter a Vin']")]
        public IWebElement inputVIN { get; set; }


        public InventoryPage SetVIN(String setVal)
        {
            Thread.Sleep(5000);

            inputVIN.SendKeys(setVal);
            return GetInstance<InventoryPage>();
        }

    }
}
