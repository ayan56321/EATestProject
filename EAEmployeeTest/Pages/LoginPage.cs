using System.Threading;
using EAAutoFramework.Base;
using EAAutoFramework.Extensions;
using EAAutoFramework.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace EAEmployeeTest.Pages
{
    class LoginPage : BasePage
    {
        //Objects for the login page
        [FindsBy(How = How.XPath, Using = "//a[text()='Terms & Conditions']")]
        IWebElement linkTermsConditions { get; set; }

        [FindsBy(How = How.Id, Using = "userName")]
        IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        IWebElement txtPassword { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(@class,'ant-btn-primary ant-btn')]")]
        IWebElement btnLogin { get; set; }


        public void Login(string userName, string password)
        {
            Thread.Sleep(5000);

            IWebElement txtUserName = XMLHelpers.readObjectValues("userNameLogin");
            txtUserName.AssertElementPresent();
            txtUserName.SendKeys(userName);

            //txtUserName.SendKeys(userName);
            txtPassword.SendKeys(password);            

        }

        public void ClickTermsConditionsLink()
        {
            linkTermsConditions.Click();
        }

        public HomePage ClickLoginBtn()
        {
            btnLogin.Click();
            return GetInstance<HomePage>();
        }


    }
}
