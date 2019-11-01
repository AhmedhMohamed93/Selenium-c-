using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Selenium_with_CSharp
{
    class AlignmentProject : TestBase
    {

        /****************************************************************************************************
         *                                                                                                  *
         *                                           Variables                                              *
         *                                                                                                  *
         ****************************************************************************************************/









        /****************************************************************************************************
         *                                                                                                  *
         *                                           Locators                                               *
         *                                                                                                  *
         ****************************************************************************************************/

        private readonly By Infusion = By.XPath("//a[contains(text(),'Infusion')]");
        private readonly By alignmentProject = By.XPath("//span[contains(text(),'Interoperability Projects')]");
        private readonly By NewalignmentProjectBtn = By.XPath("//button[@id='AddAlignmentProject']");
        private readonly By AlignmentProjectName = By.XPath("//input[@id='Name']");
        private readonly By EMRFormualry = By.XPath("//div[@class='col-md-12 form-group']//bddropdown[@name='autoCompleteControls[0].Name']//input[1]");
        private readonly By EMRSelector = By.XPath("//a[@id = 'listItemEMRFormularyList1']");
        private readonly By Facility = By.XPath("//div[@class= 'checkbox']/label");
        private readonly By UploadGRE = By.XPath("//label[@class='btn bd-btn btn-default no-margin-bottom']");
        private readonly By EMRItems = By.XPath("//div[@class='col-md-8 IvLabel pull-left']//input[1]");
        private readonly By EMRItemsSelect = By.XPath("//a[@id='listItemIVTypesList2']");
        private readonly By UploadEMR = By.XPath("//file-uploader[@id='IvFilesUploader']//label[@class='btn bd-btn btn-default no-margin-bottom'][contains(text(),'Browse')]");
        private readonly By SaveAlignmentProject = By.XPath("//div[@class='col-sm-12 tab-container-header']//span[1]");
        private readonly By AlignmentSearch = By.XPath("//input[@id='search']");
        private readonly By AlignmentProjectValidation = By.XPath("//td[1]//div[1]");
        private readonly By UploadSucessfully = By.XPath("//span[contains(text(),'File Uploaded.')]");




        /****************************************************************************************************
         *                                                                                                  *
         *                                           Methods                                                *
         *                                                                                                  *
         ****************************************************************************************************/


        /****************************************************************************************************
         *                                                                                                  *
         *   Method Name : AlignmentProject()                                                               *
         *   Inputs      : IWebDriver driver                                                                *
         *   Outputs     : Null                                                                             *
         *   Description : This Method is to initialize driver                                              *
         *                                                                                                  *
         ****************************************************************************************************/
        public AlignmentProject(IWebDriver driver)
        {
            this.driver = driver;
        }


        /****************************************************************************************************
         *                                                                                                  *
         *   Method Name : NavigateToAlignmentProject()                                                     *
         *   Inputs      : void                                                                             *
         *   Outputs     : Void                                                                             *
         *   Description : This Method is to hover Over "Infusion" tab then navigate to "Alignment Project" *
         *                                                                                                  *
         ****************************************************************************************************/

        public void NavigateToAlignmentProject()
        {
            Actions act = new Actions(driver);
            act.MoveToElement(driver.FindElement(Infusion)).Perform();
            driver.FindElement(alignmentProject).Click();
        }


        /****************************************************************************************************
         *                                                                                                  *
         *   Method Name : CreateNewAlignmentProject()                                              *
         *   Inputs      : String Alignment Project Name                                                    *
         *               : String Pharmacy Formualry Name                                                  *
         *   Outputs     : Void                                                                             *
         *   Description : This Method is to Fill all required fields in order to create Alignment Project  *
         *               : and upload GRE file and EMR Items                                                *
         *                                                                                                  *
         ****************************************************************************************************/

        [Obsolete]
        public void CreateNewAlignmentProject(String AlignmentprojectName, String EMRformualry)
        {
            WaitUntilPageLoad();
            driver.FindElement(NewalignmentProjectBtn).Click();
            driver.FindElement(AlignmentProjectName).SendKeys(AlignmentprojectName);
            //driver.FindElement(EMRFormualry).Click();
            //Thread.Sleep(1500);
            driver.FindElement(EMRFormualry).SendKeys(EMRformualry);
            driver.FindElement(EMRSelector).Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.ElementToBeClickable(Facility));
            driver.FindElement(Facility).Click();
            driver.FindElement(UploadGRE).Click();
            /* Ulpoad GRE File */
            Thread.Sleep(2000);
            SendKeys.SendWait(@"C:\Users\Ahmed.Mohamed\Documents\GitHub\Selenium-c-\Selenium with CSharp\Selenium with CSharp\Needed Files\Infusion_Demo.gre");
            SendKeys.SendWait("{Enter}");
            WaituntillfinshUpload(UploadSucessfully);
            driver.FindElement(EMRItems).Click();
            driver.FindElement(EMRItemsSelect).Click();
            driver.FindElement(UploadEMR).Click();
            /* Upload EMR Items */
            Thread.Sleep(2000);
            SendKeys.SendWait(@"C:\Users\Ahmed.Mohamed\Documents\GitHub\Selenium-c-\Selenium with CSharp\Selenium with CSharp\Needed Files\SC IV SET-Original.xls");
            SendKeys.SendWait("{Enter}");
            WaituntillfinshUpload(UploadSucessfully);
            driver.FindElement(SaveAlignmentProject).Click();
            WaitUntilPageLoad();
            Thread.Sleep(2000);
            driver.FindElement(AlignmentSearch).SendKeys(AlignmentprojectName);
            Thread.Sleep(2000);
            Assert.AreEqual(AlignmentprojectName, driver.FindElement(AlignmentProjectValidation).Text);
        }
    }
}
