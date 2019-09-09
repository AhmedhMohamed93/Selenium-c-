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
        By Formularies = By.XPath("//a[contains(text(),'Formularies')]");
        By PharmacyFormualry = By.XPath("//span[contains(text(),'Pharmacy Formularies')]");
        By NewPF = By.XPath("//button[@id='AddPharmacy']");
        By PhFName = By.XPath("//input[@id='Name']");
        By PhFID = By.XPath("//input[@id='ID']");
        By Vendor = By.XPath("//div[@class='ng-star-inserted']//input[1]");
        By associatedFacility = By.XPath("//div[@class='pharmacy-formulary-form-association-control double-margin-top double-padding-top']//input[1]");
        By associatedFacilityAdd = By.XPath("//div[@class='pharmacy-formulary-form-association-control double-margin-top double-padding-top']//button[@id='bdassociationcontrol1-add']");
        By SavePF = By.XPath("//button[@id='SaveDetailPharmacyFormulary']");
        By PharmacySearch = By.XPath("//input[@id='SearchItem']");
        By PharmacyValidation = By.XPath("//td[1]//ng2-smart-table-cell[1]//table-cell-view-mode[1]//div[1]//div[1]");

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
        public void NavigateToPharmacyFormualries()
        {
            waitUntilPageLoad();
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
        public void CreateNewPharmacyFormualry(String PFName, String PFID, String PFVendor, String FacilityName)
        {
            waitUntilPageLoad();
            driver.FindElement(NewPF).Click();
            driver.FindElement(PhFName).SendKeys(PFName);
            driver.FindElement(PhFID).SendKeys(PFID);
            driver.FindElement(Vendor).Click();
            driver.FindElement(Vendor).SendKeys(PFVendor);
            driver.FindElement(associatedFacility).Click();
            driver.FindElement(associatedFacility).SendKeys(FacilityName);
            driver.FindElement(associatedFacilityAdd).Click();
            driver.FindElement(SavePF).Click();
            waitUntilPageLoad();
            driver.FindElement(PharmacySearch).SendKeys(PFName);
            Thread.Sleep(2000);
            Assert.AreEqual(PFName , driver.FindElement(PharmacyValidation).Text);
        }
    }
}
