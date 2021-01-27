using EAAutoFramework.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using EAAutoFramework.Extensions;
using System.Threading;

namespace EAEmployeeTest.Pages
{
    // Checks this Page after click of Login Button
    public class HomePage : BasePage
    {
         
        [FindsBy(How=How.XPath, Using = "//a[contains(text(),'Terms & Conditions')]")]
        IWebElement linkPrivacyPolicy { get; set; }

        [FindsBy(How = How.XPath, Using = "//i[@class='anticon anticon-dollar']")]
        IWebElement btnTradeGrade { get; set; }

        public TradeGrade ClickTradeGradeBtn()
        {
            Thread.Sleep(5000);
            btnTradeGrade.Click();
            return GetInstance<TradeGrade>();
        }


    }

}
