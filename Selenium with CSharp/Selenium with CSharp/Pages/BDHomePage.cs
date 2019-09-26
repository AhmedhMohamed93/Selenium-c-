using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_with_CSharp
{
    class BDHomePage : TestBase
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

        private readonly By SigninBtn = By.XPath("//a[@id='anchorSignIn']");
        private readonly By UserName = By.XPath("//input[@id='username']");
        private readonly By UserPass = By.XPath("//input[@id='password']");
        private readonly By LoginBtn = By.XPath("//button[@id='sign-in']");
        private readonly By LaunchingValidation = By.XPath("//div[@class='item active']//img");
        private readonly By loginNavigation = By.XPath("//a[@class='bdshell--user-info-widget--toggle px-3 bdshell--user-info-widget--username text-light dropdown-toggle text-truncate d-none d-lg-inline']");




        /****************************************************************************************************
         *                                                                                                  *
         *                                           Methods                                                *
         *                                                                                                  *
         ****************************************************************************************************/


        /****************************************************************************************************
         *                                                                                                  *
         *   Method Name : BDHomePage()                                                                     *
         *   Inputs      : IWebDriver driver                                                                *
         *   Outputs     : Null                                                                             *
         *   Description : This Method is to initialize driver                                              *
         *                                                                                                  *
         ****************************************************************************************************/

        public BDHomePage(IWebDriver driver)
        {
            this.driver = driver;
        }



        /****************************************************************************************************
         *                                                                                                  *
         *   Method Name : Navigate()                                                                       *
         *   Inputs      : void                                                                             *
         *   Outputs     : void                                                                             *
         *   Description : This Method is to Navigate to BD website                                         *
         *                                                                                                  *
         ****************************************************************************************************/
        public void Navigate()
        {
            driver.Url = URL;
        }


        /****************************************************************************************************
         *                                                                                                  *
         *   Method Name : Login()                                                                          *
         *   Inputs      : String User name                                                                 *
         *               : String Password                                                                  *
         *   Outputs     : void                                                                             *
         *   Description : This Method is to Enter valid login credentials and login successfully           *
         *                                                                                                  *
         ****************************************************************************************************/
        public void Login(String Uname, String Password)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(SigninBtn).Click();
            driver.FindElement(UserName).SendKeys(Uname);
            driver.FindElement(UserPass).SendKeys(Password);
            driver.FindElement(LoginBtn).Click();
        }


        /****************************************************************************************************
         *                                                                                                  *
         *   Method Name : LaunchingBDWebsite()                                                             *
         *   Inputs      : String User name                                                                 *
         *               : String Password                                                                  *
         *   Outputs     : void                                                                             *
         *   Description : This Method is to Direct launch to the BD website and successfully login         *
         *                                                                                                  *
         ****************************************************************************************************/

        public void LaunchingBDWebsite(String Uname, String Password)
        {
            driver.Url = URL;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(SigninBtn).Click();
            driver.FindElement(UserName).SendKeys(Uname);
            driver.FindElement(UserPass).SendKeys(Password);
            driver.FindElement(LoginBtn).Click();
        }


        /****************************************************************************************************
         *                                                                                                  *
         *   Method Name : ValidateLaunchingPageSucessfully()                                               *
         *   Inputs      : void                                                                             *
         *   Outputs     : void                                                                             *
         *   Description : This Method is to Validate successful Navigation to BD website                   *
         *                                                                                                  *
         ****************************************************************************************************/

        [Obsolete]
        public void ValidateLaunchingPageSucessfully()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromMinutes(10));
            wait.Until(ExpectedConditions.ElementIsVisible(LaunchingValidation));
            Assert.True(driver.FindElement(LaunchingValidation).Displayed);
        }


        /****************************************************************************************************
         *                                                                                                  *
         *   Method Name : ValidateLoginPageNavigation()                                                    *
         *   Inputs      : void                                                                             *
         *   Outputs     : void                                                                             *
         *   Description : This Method is to Validate successful Login to BD website                        *
         *                                                                                                  *
         ****************************************************************************************************/

        [Obsolete]
        public void ValidateLoginPageNavigation()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromMinutes(10));
            wait.Until(ExpectedConditions.ElementIsVisible(loginNavigation));
            Assert.True(driver.FindElement(loginNavigation).Displayed);
        }
    }
}
