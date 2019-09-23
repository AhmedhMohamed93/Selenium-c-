using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using AventStack.ExtentReports;

namespace Selenium_with_CSharp.Test
{

    [TestClass, Order(5)]
    public class ValidateCreateAlignmentProject : Validations
    {
        /****************************************************************************************************
         *                               Declaration of classes Objects                                     *
         ****************************************************************************************************/
        Facility facility_1;
        AlignmentProject project_1;
        BDHomePage homePage;
        readonly Validations validStrings = new Validations();

        /****************************************************************************************************
          *                                                                                                  *
          *   Test Method Name : BD_ValidateCreationOfNewAlignmentProject()                                  *
          *   Inputs           : String browser Name                                                         *
          *   Objective        : This Test validates creation of New Alignment PRoject  within the           *
          *                    : created Health System                                                       *
          *                                                                                                  *
          ****************************************************************************************************/
        [Test]
        [Category("CreateAlignmentProject")]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        [Obsolete]
        public void BD_ValidateCreationOfNewAlignmentProject(String browserName)
        {
            Setup(browserName);
            test = extent.CreateTest(validStrings.GetCreateProjectStart());
            homePage = new BDHomePage(driver);
            facility_1 = new Facility(driver);
            project_1 = new AlignmentProject(driver);
            homePage.LaunchingBDWebsite(dataDriven.GetUserName(), dataDriven.GetUserPassword());
            test.Log(Status.Info, validStrings.GetLaunching());
            facility_1.ImpersonateIDN(dataDriven.GetIDNName());
            test.Log(Status.Info, validStrings.GetImpersonate());
            project_1.NavigateToAlignmentProject();
            test.Log(Status.Info, validStrings.GetAlignmentNavigation());
            project_1.CreateNewAlignmentProject(dataDriven.GetAlignmentProjectName(), dataDriven.GetPharmacyFormularyName());
            test.Log(Status.Info, validStrings.GetAlignmentcreationStatus());

        }
    }
}
