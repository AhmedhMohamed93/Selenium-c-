using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using AventStack.ExtentReports;

namespace Selenium_with_CSharp.Test
{
 
    [TestClass,Order(1)]    
    public class ValidateLoginAndLaunch : Validations
    {

        /****************************************************************************************************
         *                               Declaration of classes Objects                                     *
         ****************************************************************************************************/
        BDHomePage homePage;
        readonly Validations validStrings = new Validations();



        /****************************************************************************************************
         *                                                                                                  *
         *   Test Method Name : BD_ValidateLaunchWebsite()                                                  *
         *   Inputs           : String browser Name                                                         *
         *   Objective        : This Test is validating successful navigation to the BD Website             *
         *                                                                                                  *
         ****************************************************************************************************/

        [Test, Order(1)]
        [Category("Launch")]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        [Obsolete]
        public void BD_ValidateLaunchWebsite(String browserName)
        {
            Setup(browserName);
            test = extent.CreateTest(validStrings.GetlaunchStart());
            homePage = new BDHomePage(driver);
            homePage.Navigate();
            test.Log(Status.Info, validStrings.GetnavigationString());
            homePage.ValidateLaunchingPageSucessfully();
            test.Log(Status.Info, validStrings.GetlaunchStatus());
        }

        /****************************************************************************************************
          *                                                                                                  *
          *   Test Method Name : BD_LoginSuccessfully()                                                      *
          *   Inputs           : String browser Name                                                         *
          *   Objective        : This Test is validating successful Login to the BD Website                  *
          *                                                                                                  *
          ****************************************************************************************************/
        [Test, Order(2)]
        [Category("Login")]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        [Obsolete]
        public void BD_LoginSuccessfully(String browserName)
        {
            Setup(browserName);
            test = extent.CreateTest(validStrings.GetloginStart());
            homePage = new BDHomePage(driver);
            homePage.Navigate();
            test.Log(Status.Info, validStrings.GetnavigationString());
            homePage.Login(dataDriven.GetUserName(), dataDriven.GetUserPassword());
            test.Log(Status.Info, validStrings.Getlogging());
            homePage.ValidateLoginPageNavigation();
            test.Log(Status.Info, validStrings.GetloginStatus());

        }

    }
}
