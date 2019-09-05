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
    public class AlignmentProjectTestCases : TestBase
    {

        /****************************************************************************************************
          *                               Declaration of classes Objects                                     *
          ****************************************************************************************************/
        Facility facility_1;
        Pharmacy pharm_1;
        AlignmentProject project_1;
        BDHomePage homePage;


        /****************************************************************************************************
         *                                                                                                  *
         *   Test Method Name : BD_ValidateLaunchWebsite()                                                  *
         *   Inputs           : String browser Name                                                         *
         *   Objective        : This Test is validatiting successful navigation to the BD Website           *
         *                                                                                                  *
         ****************************************************************************************************/

        [Test, Order(1)]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void BD_ValidateLaunchWebsite(String browserName)
        {
            Setup(browserName);
            test = extent.CreateTest(" Validation Of Launching BD Website");
            homePage = new BDHomePage(driver);
            homePage.Navigate();
            test.Log(Status.Info, "System Navigating now");
            homePage.ValidateLaunchingPageSucessfully();
            test.Log(Status.Info, "System Navigated successfully");
        }


        /****************************************************************************************************
         *                                                                                                  *
         *   Test Method Name : BD_LoginSuccessfully()                                                      *
         *   Inputs           : String browser Name                                                         *
         *   Objective        : This Test is validatiting successful Login to the BD Website                *
         *                                                                                                  *
         ****************************************************************************************************/
        [Test, Order(2)]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        public void BD_LoginSuccessfully(String browserName)
        {
            Setup(browserName);
            test = extent.CreateTest(" Validation Of Login successfully to BD Website");
            homePage = new BDHomePage(driver);
            homePage.Navigate();
            test.Log(Status.Info, "System Navigating now");
            homePage.Login(dataDriven.getUserName(), dataDriven.getUserPassword());
            test.Log(Status.Info, "System is Loging in now");
            homePage.ValidateLoginPageNavigation();
            test.Log(Status.Info, "System logged in successfully");

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
            test = extent.CreateTest(" Validation Of Create New HealthSystem");
            facility_1 = new Facility(driver);
            BDHomePage home = new BDHomePage(driver);
            home.LaunchingBDWebsite(dataDriven.getUserName(), dataDriven.getUserPassword());
            test.Log(Status.Info, "System is navigated to BD website and logged in successfully");
            facility_1.NavigateToHealthSystems();
            test.Log(Status.Info, "System is navigated Health Systems Page");
            facility_1.CreateNewIDN(dataDriven.getIDNName(), dataDriven.getiDNID());
            test.Log(Status.Info, "New IDN is created successfully");
            facility_1.ImpersonateIDN(dataDriven.getIDNName());
            test.Log(Status.Info, "New IDN is impersonated successfully");

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
            test = extent.CreateTest(" Validation Of Create New Facility");
            facility_1 = new Facility(driver);
            BDHomePage home = new BDHomePage(driver);
            home.LaunchingBDWebsite(dataDriven.getUserName(), dataDriven.getUserPassword());
            test.Log(Status.Info, "System is navigated to BD website and logged in successfully");
            facility_1.ImpersonateIDN(dataDriven.getIDNName());
            test.Log(Status.Info, "The created IDN is impersonated successfully");
            facility_1.NavigateToFacilityAndRegion();
            test.Log(Status.Info, "System is navigated to Regions and Facilities successfully");
            facility_1.CreateNewFacility(dataDriven.getFacilityName(), dataDriven.getFacilityID());
            test.Log(Status.Info, "New Facility is created successfully");
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
            test = extent.CreateTest(" Validation Of Create New Pharmacy Formualry");
            BDHomePage home = new BDHomePage(driver);
            pharm_1 = new Pharmacy(driver);
            facility_1 = new Facility(driver);
            home.LaunchingBDWebsite(dataDriven.getUserName(), dataDriven.getUserPassword());
            test.Log(Status.Info, "System is navigated to BD website and logged in successfully");
            facility_1.ImpersonateIDN(dataDriven.getIDNName());
            test.Log(Status.Info, "The created IDN is impersonated successfully");
            pharm_1.NavigateToPharmacyFormualries();
            test.Log(Status.Info, "System is navigated to Pharmacy Formularies Page successfully");
            pharm_1.CreateNewPharmacyFormualry(dataDriven.getPharmacyFormularyName(), dataDriven.getPharmacyFormularyID(), dataDriven.getPFvendor(), dataDriven.getFacilityName());
            test.Log(Status.Info, "New Pharmacy Formualry is created successfully");
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
            test = extent.CreateTest(" Validation Of Create New Alignment Project");
            BDHomePage home = new BDHomePage(driver);
            facility_1 = new Facility(driver);
            project_1 = new AlignmentProject(driver);
            home.LaunchingBDWebsite(dataDriven.excelSetup(2, 1), dataDriven.excelSetup(2, 2));
            test.Log(Status.Info, "System is navigated to BD website and logged in successfully");
            facility_1.ImpersonateIDN(dataDriven.excelSetup(1, 5));
            test.Log(Status.Info, "The created IDN is impersonated successfully");
            project_1.NavigateToAlignmentProject();
            test.Log(Status.Info, "System is navigated to Alignment Projects Page successfully");
            project_1.CreateNewPharmacyAlignmentProject(dataDriven.excelSetup(8, 5), dataDriven.excelSetup(5, 5));
            test.Log(Status.Info, "New Alignment Project is created successfully");

        }
    }
}






