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
    class Facility : TestBase
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

        By adminMenu = By.XPath("//a[contains(text(),'Admin')]");
        By healthSystemDropDown = By.XPath("//span[contains(text(),'Health Systems')]");
        By newHealthSystem = By.XPath("//button[@id='NewHealthSystemOrg']");
        By HealthSysName = By.XPath("//input[@id='HealthSystemOrgName']");
        By HealthSysID = By.XPath("//input[@id='HealthSystemOrgID']");
        By AnchorProduct = By.XPath("//label[contains(text(),'Alaris')]");
        By saveBtn = By.XPath("//button[@id='SaveHealthSystemOrg']");
        By ActAs = By.XPath("//input[@id='ActingAsDropdown']");
        By IdnValidation = By.XPath("(//div[@class='bd-title']/span)[1]");
        By facility = By.XPath("//span[contains(text(),'Regions and Facilities')]");
        By newFacility = By.XPath("//button[@id='NewRegionFacility']");
        By facilityName = By.XPath("//input[@id='FacilityName']");
        By facilityID = By.XPath("//input[@id='FacilityUniqueId']");
        By SaveFacility = By.XPath("//button[@id='SaveFacilityRegion']");
        By facilitySearch = By.XPath("//input[@id='SearchRegionFacility']");
        By FacilityValidation = By.XPath("//td[2]//ng2-smart-table-cell[1]//table-cell-view-mode[1]//div[1]//div[1]");


        /****************************************************************************************************
         *                                                                                                  *
         *                                           Methods                                                *
         *                                                                                                  *
         ****************************************************************************************************/



        /****************************************************************************************************
         *                                                                                                  *
         *   Method Name : Facility()                                                                       *
         *   Inputs      : IWebDriver driver                                                                *
         *   Outputs     : Null                                                                             *
         *   Description : This Method is to initialize driver                                              *
         *                                                                                                  *
         ****************************************************************************************************/
        public Facility(IWebDriver driver)
        {
            this.driver = driver;
        }


        /****************************************************************************************************
         *                                                                                                  *
         *   Method Name : NavigateToHealthSystems()                                                        *
         *   Inputs      : void                                                                             *
         *   Outputs     : Void                                                                             *
         *   Description : This Method is to hover Over "Admin" menu then select navigate to "HealthSyatem" *
         *                                                                                                  *
         ****************************************************************************************************/
        public void NavigateToHealthSystems()
        {
            Actions act = new Actions(driver);
            act.MoveToElement(driver.FindElement(adminMenu)).Perform();
            driver.FindElement(healthSystemDropDown).Click();
        }


        /****************************************************************************************************
         *                                                                                                  *
         *   Method Name : CreateNewIDN()                                                                   *
         *   Inputs      : String IDN Name                                                                  *
         *               : String IDNID                                                                     *
         *   Outputs     : Void                                                                             *
         *   Description : This Method is to Create new Health system and fill all required fields in the   *
         *               : displayed dialog                                                                 *
         *                                                                                                  *
         ****************************************************************************************************/
        public void CreateNewIDN(String IDNName, String IDNID)
        {
            waitUntilPageLoad();
            driver.FindElement(newHealthSystem).Click();
            Thread.Sleep(1000);
            driver.FindElement(HealthSysName).SendKeys(IDNName);
            Thread.Sleep(1000);
            driver.FindElement(HealthSysID).SendKeys(IDNID);
            driver.FindElement(AnchorProduct).Click();
            driver.FindElement(saveBtn).Click();
            waitUntilPageLoad();
            driver.FindElement(ActAs).Click();
            driver.FindElement(ActAs).SendKeys(IDNName);
            Assert.AreEqual("to " + IDNName, driver.FindElement(IdnValidation).Text);
        }

        /****************************************************************************************************
         *                                                                                                  *
         *   Method Name : ImpersonateIDN()                                                                 *
         *   Inputs      : String IDN Name                                                                  *
         *   Outputs     : Void                                                                             *
         *   Description : This Method is to navigate to the created IDN from Act as dropdown list          *
         *                                                                                                  *
         ****************************************************************************************************/
        public void ImpersonateIDN(String IDNName)
        {
            waitUntilPageLoad();
            driver.FindElement(ActAs).Click();
            driver.FindElement(ActAs).SendKeys(IDNName);
            Assert.AreEqual("to " + IDNName , driver.FindElement(IdnValidation).Text);
        }


        /****************************************************************************************************
         *                                                                                                  *
         *   Method Name : NavigateToFacilityAndRegion()                                                    *
         *   Inputs      : void                                                                             *
         *   Outputs     : Void                                                                             *
         *   Description : This Method is to navigate to "Facilities" ana Regions from "Admin" menu         *
         *                                                                                                  *
         ****************************************************************************************************/
        public void NavigateToFacilityAndRegion()
        {
            waitUntilPageLoad();
            Actions act = new Actions(driver);
            act.MoveToElement(driver.FindElement(adminMenu)).Perform();
            driver.FindElement(facility).Click();
        }


        /****************************************************************************************************
         *                                                                                                  *
         *   Method Name : CreateNewFacility()                                                              *
         *   Inputs      : String Facility Name                                                             *
         *               : String Facility ID                                                               *
         *   Outputs     : Void                                                                             *
         *   Description : This Method is to Create new Facility and fill all required fields               *
         *                                                                                                  *
         ****************************************************************************************************/
        public void CreateNewFacility(String FacilityName, String FacilityID)
        {
            waitUntilPageLoad();
            driver.FindElement(newFacility).Click();
            driver.FindElement(facilityName).SendKeys(FacilityName);
            driver.FindElement(facilityID).SendKeys(FacilityID);
            driver.FindElement(SaveFacility).Click();
            waitUntilPageLoad();
            driver.FindElement(facilitySearch).SendKeys(FacilityName);
            Thread.Sleep(2000);
            Assert.AreEqual(FacilityName , driver.FindElement(FacilityValidation).Text);
        }
    }
}
