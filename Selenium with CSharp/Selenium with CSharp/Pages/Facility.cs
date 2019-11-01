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

        private readonly By adminMenu = By.XPath("//a[contains(text(),'Admin')]");
        private readonly By healthSystemDropDown = By.XPath("//span[contains(text(),'Health Systems')]");
        private readonly By newHealthSystem = By.XPath("//button[@id='NewHealthSystemOrg']");
        private readonly By HealthSysName = By.XPath("//input[@id='HealthSystemOrgName']");
        private readonly By HealthSysID = By.XPath("//input[@id='HealthSystemOrgID']");
        private readonly By AnchorProduct = By.XPath("//label[contains(text(),'Alaris')]");
        private readonly By saveBtn = By.XPath("//button[@id='SaveHealthSystemOrg']");
        private readonly By idnComplete = By.XPath("//body[@class='modal-open']/app/div[@id='main-wrapper']/ng-component[@class='ng-star-inserted']/modal/div[@class='modal fade in show']/div[@class='modal-dialog modal-lg']/div[@class='modal-content']/div[@class='modal-body']/form[@id='FormHealthSystemOrg']/div[@class='row']/div[2]");
        private readonly By ActAs = By.XPath("//input[@id='ActingAsDropdown']");
        private readonly By IdnValidation = By.XPath("(//div[@class='bd-title']/span)[1]");
        private readonly By facility = By.XPath("//span[contains(text(),'Regions and Facilities')]");
        private readonly By newFacility = By.XPath("//button[@id='NewRegionFacility']");
        private readonly By facilityName = By.XPath("//input[@id='FacilityName']");
        private readonly By facilityID = By.XPath("//input[@id='FacilityUniqueId']");
        private readonly By SaveFacility = By.XPath("//button[@id='SaveFacilityRegion']");
        private readonly By facilitySearch = By.XPath("//input[@id='search']");
        private readonly By FacilityValidation = By.XPath("//td[2]//div[1]//span[1]");


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
        [Obsolete]
        public void CreateNewIDN(String IDNName, String IDNID)
        {
            WaitUntilPageLoad();
            driver.FindElement(newHealthSystem).Click();
            Thread.Sleep(1000);
            driver.FindElement(HealthSysName).SendKeys(IDNName);
            Thread.Sleep(1000);
            driver.FindElement(HealthSysID).SendKeys(IDNID);
            driver.FindElement(AnchorProduct).Click();
            driver.FindElement(saveBtn).Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(idnComplete));
        }

        /****************************************************************************************************
         *                                                                                                  *
         *   Method Name : ImpersonateIDN()                                                                 *
         *   Inputs      : String IDN Name                                                                  *
         *   Outputs     : Void                                                                             *
         *   Description : This Method is to navigate to the created IDN from Act as dropdown list          *
         *                                                                                                  *
         ****************************************************************************************************/
        [Obsolete]
        public void ImpersonateIDN(String IDNName)
        {
            WaitUntilPageLoad();
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
        [Obsolete]
        public void NavigateToFacilityAndRegion()
        {
            WaitUntilPageLoad();
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
        [Obsolete]
        public void CreateNewFacility(String FacilityName, String FacilityID)
        {
            WaitUntilPageLoad();
            driver.FindElement(newFacility).Click();
            driver.FindElement(facilityName).SendKeys(FacilityName);
            driver.FindElement(facilityID).SendKeys(FacilityID);
            driver.FindElement(SaveFacility).Click();
            WaitUntilPageLoad();
            driver.FindElement(facilitySearch).SendKeys(FacilityName);
            Thread.Sleep(2000);
            Assert.AreEqual(FacilityName , driver.FindElement(FacilityValidation).Text);
        }
    }
}
