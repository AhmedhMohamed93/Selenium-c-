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

        By Infusion = By.XPath("//a[contains(text(),'Infusion')]");
        By alignmentProject = By.XPath("//span[contains(text(),'Alignment Projects')]");
        By NewalignmentProjectBtn = By.XPath("/html[1]/body[1]/app[1]/div[1]/ng-component[1]/div[1]/div[2]/tabset[1]/div[1]/ng-component[1]/div[1]/div[1]/div[1]/div[1]/div[2]/button[4]");
        By AlignmentProjectName = By.XPath("//input[@id='Name']");
        By EMRFormualry = By.XPath("//div[@class='col-md-5']//bddropdown[@name='autoCompleteControls[0].Name']//input[1]");
        By Facility = By.XPath("//div[@class= 'checkbox']/label");
        By UploadGRE = By.XPath("//label[@class='btn btn-default']");
        By EMRItems = By.XPath("//div[@class='col-md-4 IvLabel']//input[1]");
        By EMRItemsSelect = By.XPath("//a[@id='listItemIVTypesList2']");
        By UploadEMR = By.XPath("//file-uploader[@id='IvFiles Uploader']//label[@class='btn btn-default'][contains(text(),'Browse')]");
        By SaveAlignmentProject = By.XPath("//div[@class='col-sm-12 tab-container-header']//span[1]");
        By AlignmentSearch = By.XPath("//input[@id='SearchItem']");
        By AlignmentProjectValidation = By.XPath("//td[1]//ng2-smart-table-cell[1]//table-cell-view-mode[1]//div[1]//div[1]");
        By UploadSucessfully = By.XPath("//span[contains(text(),'File Uploaded.')]");
        By selectPF = By.XPath("//a[@id='listItemEMRFormularyList1']");




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
         *   Method Name : CreateNewPharmacyAlignmentProject()                                              *
         *   Inputs      : String Alignment Project Name                                                    *
         *               : String Pharmacy Foprmualry Name                                                  *
         *   Outputs     : Void                                                                             *
         *   Description : This Method is to Fill all required fields in order to create Alignment Project  *
         *               : and upload GRE file and EMR Items                                                *
         *                                                                                                  *
         ****************************************************************************************************/

        public void CreateNewAlignmentProject(String AlignmentprojectName, String EMRformualry)
        {
            waitUntilPageLoad();
            driver.FindElement(NewalignmentProjectBtn).Click();
            driver.FindElement(AlignmentProjectName).SendKeys(AlignmentprojectName);
            driver.FindElement(EMRFormualry).Click();
            driver.FindElement(EMRFormualry).SendKeys(EMRformualry);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.ElementToBeClickable(Facility));
            driver.FindElement(Facility).Click();
            driver.FindElement(UploadGRE).Click();
            /* Ulpoad GRE File */
            Thread.Sleep(2000);
            SendKeys.SendWait(@"C:\Users\ahmed.mohamed\source\repos\POC\POC\Needed Files\Infusion_Demo.gre");
            SendKeys.SendWait("{Enter}");
            waituntillfinshUpload(UploadSucessfully);
            driver.FindElement(EMRItems).Click();
            driver.FindElement(EMRItemsSelect).Click();
            driver.FindElement(UploadEMR).Click();
            /* Upload EMR Items */
            Thread.Sleep(2000);
            SendKeys.SendWait(@"C:\Users\ahmed.mohamed\source\repos\POC\POC\Needed Files\SC IV SET-Original.xls");
            SendKeys.SendWait("{Enter}");
            waituntillfinshUpload(UploadSucessfully);
            driver.FindElement(SaveAlignmentProject).Click();
            waitUntilPageLoad();
            Thread.Sleep(2000);
            driver.FindElement(AlignmentSearch).SendKeys(AlignmentprojectName);
            Thread.Sleep(2000);
            Assert.AreEqual(AlignmentprojectName, driver.FindElement(AlignmentProjectValidation).Text);
        }
    }
}
