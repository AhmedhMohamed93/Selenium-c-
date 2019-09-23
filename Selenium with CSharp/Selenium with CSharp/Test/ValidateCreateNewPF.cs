using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using AventStack.ExtentReports;

namespace Selenium_with_CSharp.Test
{

    [TestClass, Order(4)]
    public class ValidateCreateNewPF : Validations
    {

        /****************************************************************************************************
         *                               Declaration of classes Objects                                     *
         ****************************************************************************************************/
        Facility facility_1;
        Pharmacy pharm_1;
        BDHomePage homePage;
        readonly Validations validStrings = new Validations();

        /****************************************************************************************************
         *                                                                                                  *
         *   Test Method Name : BD_ValidateCreationOfNewPharmacyFormualry()                                 *
         *   Inputs           : String browser Name                                                         *
         *   Objective        : This Test validates creation of New Pharmacy Formualry within the           *
         *                    : created Health System                                                       *
         *                                                                                                  *
         ****************************************************************************************************/
        [Test]
        [Category("CreatePF")]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        [Obsolete]
        public void BD_ValidateCreationOfNewPharmacyFormualry(String browserName)
        {
            Setup(browserName);
            test = extent.CreateTest(validStrings.GetCreatePharmacyStart());
            homePage = new BDHomePage(driver);
            pharm_1 = new Pharmacy(driver);
            facility_1 = new Facility(driver);
            homePage.LaunchingBDWebsite(dataDriven.GetUserName(), dataDriven.GetUserPassword());
            test.Log(Status.Info, validStrings.GetLaunching());
            facility_1.ImpersonateIDN(dataDriven.GetIDNName());
            test.Log(Status.Info, validStrings.GetImpersonate());
            pharm_1.NavigateToPharmacyFormualries();
            test.Log(Status.Info, validStrings.GetpharmacyNavigation());
            pharm_1.CreateNewPharmacyFormualry(dataDriven.GetPharmacyFormularyName(), dataDriven.GetPharmacyFormularyID(), dataDriven.GetPFvendor(), dataDriven.GetFacilityName());
            test.Log(Status.Info, validStrings.GetpharmacycreationStatus());
        }
    }
}
