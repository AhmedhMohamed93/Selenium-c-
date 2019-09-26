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

namespace Selenium_with_CSharp
{
    class Pharmacy : TestBase
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
        private readonly By Formularies = By.XPath("//a[contains(text(),'Formularies')]");
        private readonly By PharmacyFormualry = By.XPath("//span[contains(text(),'Pharmacy Formularies')]");
        private readonly By NewPF = By.XPath("//button[@id='AddPharmacy']");
        private readonly By PhFName = By.XPath("//input[@id='Name']");
        private readonly By PhFID = By.XPath("//input[@id='ID']");
        private readonly By Vendor = By.XPath("//div[@class='ng-star-inserted']//input[1]");
        private readonly By associatedFacility = By.XPath("//div[@class='pharmacy-formulary-form-association-control double-margin-top double-padding-top']//input[1]");
        private readonly By associatedFacilityAdd = By.XPath("//div[@class='pharmacy-formulary-form-association-control double-margin-top double-padding-top']//button[@id='bdassociationcontrol1-add']");
        private readonly By SavePF = By.XPath("//button[@id='SaveDetailPharmacyFormulary']");
        private readonly By PharmacySearch = By.XPath("//input[@id='SearchItem']");
        private readonly By PharmacyValidation = By.XPath("//td[1]//ng2-smart-table-cell[1]//table-cell-view-mode[1]//div[1]//div[1]");

        /****************************************************************************************************
         *                                                                                                  *
         *                                           Methods                                                *
         *                                                                                                  *
         ****************************************************************************************************/



        /****************************************************************************************************
         *                                                                                                  *
         *   Method Name : Pharmacy()                                                                       *
         *   Inputs      : IWebDriver driver                                                                *
         *   Outputs     : Null                                                                             *
         *   Description : This Method is to initialize driver                                              *
         *                                                                                                  *
         ****************************************************************************************************/
        public Pharmacy(IWebDriver driver)
        {
            this.driver = driver;
        }


        /****************************************************************************************************
         *                                                                                                  *
         *   Method Name : NavigateToPharmacyFormualries()                                                  *
         *   Inputs      : void                                                                             *
         *   Outputs     : void                                                                             *
         *   Description : This Method is to hover Over "Admin" menu then select navigate to "HealthSyatem" *
         *                                                                                                  *
         ****************************************************************************************************/
        [Obsolete]
        public void NavigateToPharmacyFormualries()
        {
            WaitUntilPageLoad();
            Actions act = new Actions(driver);
            act.MoveToElement(driver.FindElement(Formularies)).Perform();
            driver.FindElement(PharmacyFormualry).Click();
        }


        /****************************************************************************************************
         *                                                                                                  *
         *   Method Name : CreateNewPharmacyFormualry()                                                     *
         *   Inputs      : String Pharmacy Formualry Name                                                   *
         *               : String Pharmacy Formaulry ID                                                     *
         *               : String Vendor                                                                    *
         *               : String Facility Name                                                             *
         *   Outputs     : Void                                                                             *
         *   Description : This Method is to Create new Pharmacy Formulary and fill all required fields     *
         *               :  in the displayed dialog                                                         *
         *                                                                                                  *
         ****************************************************************************************************/
        [Obsolete]
        public void CreateNewPharmacyFormualry(String PFName, String PFID, String PFVendor, String FacilityName)
        {
            WaitUntilPageLoad();
            driver.FindElement(NewPF).Click();
            driver.FindElement(PhFName).SendKeys(PFName);
            driver.FindElement(PhFID).SendKeys(PFID);
            driver.FindElement(Vendor).Click();
            driver.FindElement(Vendor).SendKeys(PFVendor);
            driver.FindElement(associatedFacility).Click();
            driver.FindElement(associatedFacility).SendKeys(FacilityName);
            driver.FindElement(associatedFacilityAdd).Click();
            driver.FindElement(SavePF).Click();
            WaitUntilPageLoad();
            driver.FindElement(PharmacySearch).SendKeys(PFName);
            Thread.Sleep(2000);
            Assert.AreEqual(PFName , driver.FindElement(PharmacyValidation).Text);
        }
    }
}
