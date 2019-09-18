using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_with_CSharp
{
    public class TestBase
    {

        /****************************************************************************************************
         *                                                                                                  *
         *                                           Variables                                              *
         *                                                                                                  *
         ****************************************************************************************************/
        /*Web Driver Object*/
        protected IWebDriver driver;

        /*Extent Report Variables*/
        public static ExtentReports extent;
        public static ExtentHtmlReporter htmlReporter;
        public static ExtentTest test;


        /* Initialization of Data Driven Object */

        protected TestData dataDriven = new TestData();

        /****************************************************************************************************
         *                                                                                                  *
         *                                           Locators                                               *
         *                                                                                                  *
         ****************************************************************************************************/

        readonly By WaitCondition = By.CssSelector("ajax-loader > div.loadingplaceholder");


        /****************************************************************************************************
         *                                                                                                  *
         *                                           Methods                                                *
         *                                                                                                  *
         ****************************************************************************************************/

        /****************************************************************************************************
         *                                                                                                  *
         *   Method Name : BrowserToRunWith()                                                               *
         *   Inputs      : void                                                                             *
         *   Outputs     : IEnumerable<String>                                                              *
         *   Description : This Method is to Handle multiple browsers for execution                         *
         *                                                                                                  *
         ****************************************************************************************************/

        public static IEnumerable<String> BrowserToRunWith()
        {
            String[] browsers = AutomationSettings.browsersToRunWith.Split(',');
            foreach (String b in browsers)
            {
                yield return b;
            }

        }


        /****************************************************************************************************
         *                                                                                                  *
         *   Method Name : getInstance()                                                                    *
         *   Inputs      : void                                                                             *
         *   Outputs     : ExtentReport Object                                                              *
         *   Description : This Method is to Handle multiple Extent Report objects                          *
         *                                                                                                  *
         ****************************************************************************************************/
        public static ExtentReports GetInstance()
        {
            if (extent == null)
            {
                extent = new ExtentReports();
            }
            return extent;
        }

        /****************************************************************************************************
         *                                                                                                  *
         *   Method Name : Setup()                                                                          *
         *   Inputs      : String browserName                                                               *
         *   Outputs     : void                                                                             *
         *   Description : This Method is to Handle Web Driver referencing and Extent Report configuration  *
         *                                                                                                  *
         ****************************************************************************************************/

        public void Setup(String browserName)
        {

            /****************************************************************************************************
             *                                   Handling Web driver referencing                                *
             ****************************************************************************************************/

            if (browserName.Equals("Chrome"))
            {
                driver = new ChromeDriver();
            }
            else if (browserName.Equals("Firefox"))
            {
                driver = new FirefoxDriver();
            }
            else if (browserName.Equals("IE"))
            {
                driver = new InternetExplorerDriver();
            }

            driver.Manage().Window.Maximize();

            /****************************************************************************************************
             *                                   Handling Extent Report attributes                              *
             ****************************************************************************************************/

            htmlReporter = new ExtentHtmlReporter(@"C:\Users\ahmed.mohamed\Documents\GitHub\Selenium-c-\Selenium with CSharp\TestResults\report.html");
            htmlReporter.Config.Theme = Theme.Dark;
            htmlReporter.Config.DocumentTitle = "Test Report";

            
            htmlReporter.Config.ReportName = "Generate Alignment Project Test Report";
            GetInstance();
            extent.AttachReporter(htmlReporter);
        }

        /****************************************************************************************************
         *                                                                                                  *
         *   Method Name : waituntillfinshUpload()                                                          *
         *   Inputs      : By element                                                                       *
         *   Outputs     : void                                                                             *
         *   Description : This Method is to wait until finishing upload GRE file ans also IV File          *
         *                                                                                                  *
         ****************************************************************************************************/

        [Obsolete]
        public void WaituntillfinshUpload(By element)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromMinutes(10));
            wait.Until(ExpectedConditions.ElementExists(element));
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(element));
        }


        /****************************************************************************************************
         *                                                                                                  *
         *   Method Name : waituntillPageUpload()                                                           *
         *   Inputs      : void                                                                             *
         *   Outputs     : void                                                                             *
         *   Description : This Method is to wait until ajax loader finish loading the page                 *
         *                                                                                                  *
         ****************************************************************************************************/
        [Obsolete]
        public void WaitUntilPageLoad()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(WaitCondition));
	    }



    /****************************************************************************************************
     *                                                                                                  *
     *   Method Name : End()                                                                            *
     *   Inputs      : void                                                                             *
     *   Outputs     : void                                                                             *
     *   Description : This Method is to Generate Extent Report for each test                           *
     *                                                                                                  *
     ****************************************************************************************************/

    [TearDown]
        public void End()
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var errormsg = TestContext.CurrentContext.Result.Message;

            if (status == NUnit.Framework.Interfaces.TestStatus.Failed)
            {
                test.Log(Status.Fail, status + errormsg);
            }
            else
            {
                test.Log(Status.Pass, status + errormsg);
            }
            extent.Flush();
        }


        /****************************************************************************************************
         *                                                                                                  *
         *   Method Name : EndTest()                                                                        *
         *   Inputs      : void                                                                             *
         *   Outputs     : void                                                                             *
         *   Description : This Method is to close the Web Driver                                           *
         *                                                                                                  *
         ****************************************************************************************************/
        [OneTimeTearDown]
        public void EndTest()
        {
            driver.Quit();
        }
    }
}
