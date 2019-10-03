using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using AventStack.ExtentReports;

namespace Selenium_with_CSharp.Test
{

    [TestClass, Order(3)]
    public class ValidateCreateNewfacility : Validations
    {
        /****************************************************************************************************
         *                               Declaration of classes Objects                                     *
         ****************************************************************************************************/
        Facility facility_1;
        readonly Validations validStrings = new Validations();

        /****************************************************************************************************
         *                                                                                                  *
         *   Test Method Name : BD_ValidateCreationOfNewFacility()                                          *
         *   Inputs           : String browser Name                                                         *
         *   Objective        : This Test validates creation of New facility within the created Health      *
         *                    : System                                                                      *
         *                                                                                                  *
         ****************************************************************************************************/
        [Test]
        [Category("CreateFacility")]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        [Obsolete]
        public void BD_ValidateCreationOfNewFacility(String browserName)
        {
            Setup(browserName);
            test = extent.CreateTest(validStrings.GetCreateFacilityStart());
            facility_1 = new Facility(driver);
            BDHomePage home = new BDHomePage(driver);
            home.LaunchingBDWebsite(dataDriven.GetUserName(), dataDriven.GetUserPassword());
            test.Log(Status.Info, validStrings.GetLaunching());
            facility_1.ImpersonateIDN(dataDriven.GetIDNName());
            test.Log(Status.Info, validStrings.GetImpersonate());
            facility_1.NavigateToFacilityAndRegion();
            test.Log(Status.Info, validStrings.GetfacilityNavigation());
            facility_1.CreateNewFacility(dataDriven.GetFacilityName(), dataDriven.GetFacilityID());
            test.Log(Status.Info, validStrings.GetfacilitycreationStatus());
            Capture(validStrings.GetFacilityscreenshotName());
            test.Log(Status.Info, validStrings.GetconfirmScreenshot());
        }
    }
}
