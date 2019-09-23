using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using AventStack.ExtentReports;

namespace Selenium_with_CSharp.Test
{
  
    [TestClass, Order(2)]
    public class ValidateCreateNewIDN : Validations
    {
        /****************************************************************************************************
         *                               Declaration of classes Objects                                     *
         ****************************************************************************************************/
        BDHomePage homePage;
        Facility facility_1;
        readonly Validations validStrings = new Validations();

        /****************************************************************************************************
         *                                                                                                  *
         *   Test Method Name : BD_ValidateCreationOfNewHealthSystem()                                      *
         *   Inputs           : String browser Name                                                         *
         *   Objective        : This Test validates creation of New Health System then impersonate it       *
         *                                                                                                  *
         ****************************************************************************************************/
        [Test]
        [Category("CreateIDN")]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        [Obsolete]
        public void BD_ValidateCreationOfNewHealthSystem(String browserName)
        {
            Setup(browserName);
            test = extent.CreateTest(validStrings.GetCreateIDNStart());
            facility_1 = new Facility(driver);
            homePage = new BDHomePage(driver);
            homePage.LaunchingBDWebsite(dataDriven.GetUserName(), dataDriven.GetUserPassword());
            test.Log(Status.Info, validStrings.GetLaunching());
            facility_1.NavigateToHealthSystems();
            test.Log(Status.Info, validStrings.GetIDNNavigation());
            facility_1.CreateNewIDN(dataDriven.GetIDNName(), dataDriven.GetiDNID());
            test.Log(Status.Info, validStrings.GetsuccessfulCreationOfIDN());
            facility_1.ImpersonateIDN(dataDriven.GetIDNName());
            test.Log(Status.Info, validStrings.GetCreationStatus());
        }

    }
}
