using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using EAEmployeeTest.Pages;
using EAAutoFramework.Base;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;
using EAAutoFramework.Helpers;
using EAAutoFramework.Config;

namespace EAEmployeeTest
{
    [TestClass]
    public class UnitTest1 : HookInitialize
    {

        [TestMethod]
        public void TestMethod1()
        {
            string fileName = Environment.CurrentDirectory.ToString() + "\\Data\\Login.xlsx";

            ExcelHelpers.PopulateInCollection(fileName);


            //LoginPage
            CurrentPage = GetInstance<LoginPage>();
            CurrentPage.As<LoginPage>().ClickTermsConditionsLink();
            CurrentPage.As<LoginPage>().Login(ExcelHelpers.ReadData(1, "UserName"), ExcelHelpers.ReadData(1, "Password"));
            LogHelpers.Write("Login into Application Using "+ ExcelHelpers.ReadData(1, "UserName"));

            //Navigating to TradeGrade
            CurrentPage = CurrentPage.As<HomePage>().ClickTradeGradeBtn();
            LogHelpers.Write("Browser is Opened");
            CurrentPage.As<TradeGrade>().SetVIN("XDGHYFG");


        }
    }
}
