using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Selenium_with_CSharp
{
    [TestClass]
    public class AlignmentProjectTestCases : Validations
    {

        /****************************************************************************************************
         *                               Declaration of classes Objects                                     *
         ****************************************************************************************************/
        Facility facility_1;
        Pharmacy pharm_1;
        AlignmentProject project_1;
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
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        [Obsolete]
        public void BD_ValidateLaunchWebsite(String browserName)
        {
            Setup(browserName);
            test = extent.CreateTest(validStrings.GetlaunchStart());
            homePage = new BDHomePage(driver);
            homePage.Navigate();
            test.Log(Status.Info,validStrings.GetnavigationString());
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


        /****************************************************************************************************
         *                                                                                                  *
         *   Test Method Name : BD_ValidateCreationOfNewHealthSystem()                                      *
         *   Inputs           : String browser Name                                                         *
         *   Objective        : This Test validates creation of New Health System then impersonate it       *
         *                                                                                                  *
         ****************************************************************************************************/
        [Test, Order(3)]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        [Obsolete]
        public void BD_ValidateCreationOfNewHealthSystem(String browserName)
        {
            Setup(browserName);
            test = extent.CreateTest(validStrings.GetCreateIDNStart());
            facility_1 = new Facility(driver);
            BDHomePage home = new BDHomePage(driver);
            home.LaunchingBDWebsite(dataDriven.GetUserName(), dataDriven.GetUserPassword());
            test.Log(Status.Info, validStrings.GetLaunching());
            facility_1.NavigateToHealthSystems();
            test.Log(Status.Info, validStrings.GetIDNNavigation());
            facility_1.CreateNewIDN(dataDriven.GetIDNName(), dataDriven.GetiDNID());
            test.Log(Status.Info, validStrings.GetsuccessfulCreationOfIDN());
            facility_1.ImpersonateIDN(dataDriven.GetIDNName());
            test.Log(Status.Info, validStrings.GetCreationStatus());

        }

        /****************************************************************************************************
         *                                                                                                  *
         *   Test Method Name : BD_ValidateCreationOfNewFacility()                                          *
         *   Inputs           : String browser Name                                                         *
         *   Objective        : This Test validates creation of New facility within the created Health      *
         *                    : System                                                                      *
         *                                                                                                  *
         ****************************************************************************************************/
        [Test, Order(4)]
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
            test.Log(Status.Info,validStrings.GetImpersonate());
            facility_1.NavigateToFacilityAndRegion();
            test.Log(Status.Info, validStrings.GetfacilityNavigation());
            facility_1.CreateNewFacility(dataDriven.GetFacilityName(), dataDriven.GetFacilityID());
            test.Log(Status.Info, validStrings.GetfacilitycreationStatus());
        }


        /****************************************************************************************************
         *                                                                                                  *
         *   Test Method Name : BD_ValidateCreationOfNewPharmacyFormualry()                                 *
         *   Inputs           : String browser Name                                                         *
         *   Objective        : This Test validates creation of New Pharmacy Formualry within the           *
         *                    : created Health System                                                       *
         *                                                                                                  *
         ****************************************************************************************************/
        [Test, Order(5)]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        [Obsolete]
        public void BD_ValidateCreationOfNewPharmacyFormualry(String browserName)
        {
            Setup(browserName);
            test = extent.CreateTest(validStrings.GetCreatePharmacyStart());
            BDHomePage home = new BDHomePage(driver);
            pharm_1 = new Pharmacy(driver);
            facility_1 = new Facility(driver);
            home.LaunchingBDWebsite(dataDriven.GetUserName(), dataDriven.GetUserPassword());
            test.Log(Status.Info, validStrings.GetLaunching());
            facility_1.ImpersonateIDN(dataDriven.GetIDNName());
            test.Log(Status.Info, validStrings.GetImpersonate());
            pharm_1.NavigateToPharmacyFormualries();
            test.Log(Status.Info, validStrings.GetpharmacyNavigation());
            pharm_1.CreateNewPharmacyFormualry(dataDriven.GetPharmacyFormularyName(), dataDriven.GetPharmacyFormularyID(), dataDriven.GetPFvendor(), dataDriven.GetFacilityName());
            test.Log(Status.Info, validStrings.GetpharmacycreationStatus());
        }


        /****************************************************************************************************
         *                                                                                                  *
         *   Test Method Name : BD_ValidateCreationOfNewAlignmentProject()                                  *
         *   Inputs           : String browser Name                                                         *
         *   Objective        : This Test validates creation of New Alignment PRoject  within the           *
         *                    : created Health System                                                       *
         *                                                                                                  *
         ****************************************************************************************************/
        [Test, Order(6)]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        [Obsolete]
        public void BD_ValidateCreationOfNewAlignmentProject(String browserName)
        {
            Setup(browserName);
            test = extent.CreateTest(validStrings.GetCreateProjectStart());
            BDHomePage home = new BDHomePage(driver);
            facility_1 = new Facility(driver);
            project_1 = new AlignmentProject(driver);
            home.LaunchingBDWebsite(dataDriven.GetUserName(), dataDriven.GetUserPassword());
            test.Log(Status.Info, validStrings.GetLaunching());
            facility_1.ImpersonateIDN(dataDriven.GetIDNName());
            test.Log(Status.Info,validStrings.GetImpersonate());
            project_1.NavigateToAlignmentProject();
            test.Log(Status.Info, validStrings.GetAlignmentNavigation());
            project_1.CreateNewAlignmentProject(dataDriven.GetAlignmentProjectName(), dataDriven.GetPharmacyFormularyName());
            test.Log(Status.Info, validStrings.GetAlignmentcreationStatus());

        }
    }
}






