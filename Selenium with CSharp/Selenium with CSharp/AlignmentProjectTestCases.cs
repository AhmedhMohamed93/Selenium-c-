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
        Validations validStrings = new Validations();



        /****************************************************************************************************
         *                                                                                                  *
         *   Test Method Name : BD_ValidateLaunchWebsite()                                                  *
         *   Inputs           : String browser Name                                                         *
         *   Objective        : This Test is validating successful navigation to the BD Website             *
         *                                                                                                  *
         ****************************************************************************************************/

        [Test, Order(1)]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void BD_ValidateLaunchWebsite(String browserName)
        {
            Setup(browserName);
            test = extent.CreateTest(validStrings.getlaunchStart());
            homePage = new BDHomePage(driver);
            homePage.Navigate();
            test.Log(Status.Info,validStrings.getnavigationString());
            homePage.ValidateLaunchingPageSucessfully();
            test.Log(Status.Info, validStrings.getlaunchStatus());
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
        public void BD_LoginSuccessfully(String browserName)
        {
            Setup(browserName);
            test = extent.CreateTest(validStrings.getloginStart());
            homePage = new BDHomePage(driver);
            homePage.Navigate();
            test.Log(Status.Info, validStrings.getnavigationString());
            homePage.Login(dataDriven.getUserName(), dataDriven.getUserPassword());
            test.Log(Status.Info, validStrings.getlogging());
            homePage.ValidateLoginPageNavigation();
            test.Log(Status.Info, validStrings.getloginStatus());

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
        public void BD_ValidateCreationOfNewHealthSystem(String browserName)
        {
            Setup(browserName);
            test = extent.CreateTest(validStrings.getCreateIDNStart());
            facility_1 = new Facility(driver);
            BDHomePage home = new BDHomePage(driver);
            home.LaunchingBDWebsite(dataDriven.getUserName(), dataDriven.getUserPassword());
            test.Log(Status.Info, validStrings.getLaunching());
            facility_1.NavigateToHealthSystems();
            test.Log(Status.Info, validStrings.getIDNNavigation());
            facility_1.CreateNewIDN(dataDriven.getIDNName(), dataDriven.getiDNID());
            test.Log(Status.Info, validStrings.getsuccessfulCreationOfIDN());
            facility_1.ImpersonateIDN(dataDriven.getIDNName());
            test.Log(Status.Info, validStrings.getCreationStatus());

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
        public void BD_ValidateCreationOfNewFacility(String browserName)
        {
            Setup(browserName);
            test = extent.CreateTest(validStrings.getCreateFacilityStart());
            facility_1 = new Facility(driver);
            BDHomePage home = new BDHomePage(driver);
            home.LaunchingBDWebsite(dataDriven.getUserName(), dataDriven.getUserPassword());
            test.Log(Status.Info, validStrings.getLaunching());
            facility_1.ImpersonateIDN(dataDriven.getIDNName());
            test.Log(Status.Info,validStrings.getImpersonate());
            facility_1.NavigateToFacilityAndRegion();
            test.Log(Status.Info, validStrings.getfacilityNavigation());
            facility_1.CreateNewFacility(dataDriven.getFacilityName(), dataDriven.getFacilityID());
            test.Log(Status.Info, validStrings.getfacilitycreationStatus());
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
        public void BD_ValidateCreationOfNewPharmacyFormualry(String browserName)
        {
            Setup(browserName);
            test = extent.CreateTest(validStrings.getCreatePharmacyStart());
            BDHomePage home = new BDHomePage(driver);
            pharm_1 = new Pharmacy(driver);
            facility_1 = new Facility(driver);
            home.LaunchingBDWebsite(dataDriven.getUserName(), dataDriven.getUserPassword());
            test.Log(Status.Info, validStrings.getLaunching());
            facility_1.ImpersonateIDN(dataDriven.getIDNName());
            test.Log(Status.Info, validStrings.getImpersonate());
            pharm_1.NavigateToPharmacyFormualries();
            test.Log(Status.Info, validStrings.getpharmacyNavigation());
            pharm_1.CreateNewPharmacyFormualry(dataDriven.getPharmacyFormularyName(), dataDriven.getPharmacyFormularyID(), dataDriven.getPFvendor(), dataDriven.getFacilityName());
            test.Log(Status.Info, validStrings.getpharmacycreationStatus());
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
        public void BD_ValidateCreationOfNewAlignmentProject(String browserName)
        {
            Setup(browserName);
            test = extent.CreateTest(validStrings.getCreateProjectStart());
            BDHomePage home = new BDHomePage(driver);
            facility_1 = new Facility(driver);
            project_1 = new AlignmentProject(driver);
            home.LaunchingBDWebsite(dataDriven.getUserName(), dataDriven.getUserPassword());
            test.Log(Status.Info, validStrings.getLaunching());
            facility_1.ImpersonateIDN(dataDriven.getIDNName());
            test.Log(Status.Info,validStrings.getImpersonate());
            project_1.NavigateToAlignmentProject();
            test.Log(Status.Info, validStrings.getAlignmentNavigation());
            project_1.CreateNewAlignmentProject(dataDriven.getAlignmentProjectName(), dataDriven.getPharmacyFormularyName());
            test.Log(Status.Info, validStrings.getAlignmentcreationStatus());

        }
    }
}






