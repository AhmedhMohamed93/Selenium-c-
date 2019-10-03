using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_with_CSharp
{
    public class Validations : TestBase
    {

        /****************************************************************************************************
         *                                                                                                  *
         *                                           Variables                                              *
         *                                                                                                  *
         ****************************************************************************************************/

                /*************************************************************************************
                 *                 BD_ValidateLaunchWebsite() Test Log Strings                       *
                 *************************************************************************************/
                private readonly String LaunchScreenshot = "Launching successfully the BD Website";
                private readonly String launchStart = "Validation Of Launching BD Website";
                private readonly String Navigation = "System Navigating now";
                private readonly String LaunchStatus = "System Navigated successfully";
        		private readonly String screenshot = "ScreenShot Taken";


               /*************************************************************************************
                *                 BD_LoginSuccessfully() Test Log Strings                           *
                *************************************************************************************/
                private readonly String LoginScreenshot = "Login successfully to BD Website";
                private readonly String loginStart = "Validation Of Login successfully to BD Website";
                private readonly String Logging = "System is Logging in now";
                private readonly String loginstatus = "System logged in successfully";



               /*************************************************************************************
                *             BD_ValidateCreationOfNewHealthSystem() Test Log Strings               *
                *************************************************************************************/
                private readonly String IDNScreenshot = "IDN Created successfully";
                private readonly String CreateIDNStart = "Validation Of Create New HealthSystem";
                private readonly String Launching = "System is navigated to BD website and logged in successfully";
                private readonly String IDNNavigation = "System is navigated Health Systems Page";
                private readonly String successfulCreationOfIDN = "New IDN is created successfully";
                private readonly String CreationStatus = "New IDN is impersonated successfully";

               /*************************************************************************************
                *             BD_ValidateCreationOfNewFacility() Test Log Strings                   *
                *************************************************************************************/
                private readonly String FacilityScreenshot = "New Facility Created successfully";                
                private readonly String CreateFacilityStart = "Validation Of Create New Facility";
                private readonly String facilityNavigation = "System is navigated to Regions and Facilities successfully";
                private readonly String facilitycreationStatus = "New Facility is created successfully";
                private readonly String Impersonate = "The created IDN is impersonated successfully";

               /*************************************************************************************
                *             BD_ValidateCreationOfNewPharmacyFormualry() Test Log Strings          *
                *************************************************************************************/
                private readonly String PharmacyScreenshot = "New PF Created successfully";
                private readonly String CreatePharmacyStart = "Validation Of Create New Pharmacy Formulary";
                private readonly String pharmacyNavigation = "System is navigated to Pharmacy Formularies Page successfully";
                private readonly String pharmacycreationStatus = "New Pharmacy Formualry is created successfully";

               /*************************************************************************************
                *              BD_ValidateCreationOfNewAlignmentProject() Test Log Strings           *
                *************************************************************************************/
                private readonly String AlignmentScreenshot = "New AlignmentProject Created successfully";
                private readonly String CreateProjectStart = "Validation Of Create New Alignment Project";
                private readonly String AlignmentNavigation = "System is navigated to Alignment Projects Page successfully";
                private readonly String AlignmentcreationStatus = "New Alignment Project is created successfully";


               /*************************************************************************************
                *            BD_ValidateCreationOfNewAlignmentProjectDB() Test Log Strings          *
                *************************************************************************************/

                private readonly String DBvalidationStart = "Validation of Existance of the Created Alignment Project in the DB";
                private readonly String DBConnect = "Initiate the Connection to SQL Server";
                private readonly String connecting = "Connecting to SQL Server ... ";
                private readonly String connectComplete = "Done.";
                private readonly String ReadData = "Reading data from table";

        /**********************************************************************************************************
		 *                                                                                                        *
		 *                                           Methods                                                      *
		 *                                                                                                        *
		 **********************************************************************************************************/

                   /******************************************************************************************
                    *                BD_ValidateLaunchWebsite() Test Logs getters                            *
                    ******************************************************************************************/

                    public String GetlaunchStart()
                    {
                        return launchStart;
                    }

                    public String GetnavigationString()
                    {
                        return Navigation;
                    }

                    public String GetlaunchStatus()
                    {
                        return LaunchStatus;
                    }
                    public String GetLaunchscreenshotName()
                    {
                        return LaunchScreenshot;
                    }

                    public String GetconfirmScreenshot()
                    {
                        return screenshot;
                    }



                    /******************************************************************************************
                     *                BD_LoginSuccessfully() Test Logs getters                                *
                     ******************************************************************************************/

                    public String GetloginStart()
                    {
                        return loginStart;
                    }

                    public String Getlogging()
                    {
                        return Logging;
                    }

                    public String GetloginStatus()
                    {
                        return loginstatus;
                    }

                    public String GetLoginscreenshotName()
                    {
                        return LoginScreenshot;
                    }

                   /******************************************************************************************
                    *                     BD_CreateNewIDN() Test Logs getters                                *
                    ******************************************************************************************/

                    public String GetCreateIDNStart()
                    {
                        return CreateIDNStart;
                    }

                    public String GetLaunching()
                    {
                        return Launching;
                    }

                    public String GetIDNNavigation()
                    {
                        return IDNNavigation;
                    }

                    public String GetsuccessfulCreationOfIDN()
                    {
                        return successfulCreationOfIDN;
                    }

                    public String GetCreationStatus()
                    {
                        return CreationStatus;
                    }

                    public String GetIDNscreenshotName()
                    {
                        return IDNScreenshot;
                    }


                    /******************************************************************************************
                     *                    BD_ValidateCreationOfNewFacility() Test Logs getters                *
                     ******************************************************************************************/

                    public String GetCreateFacilityStart()
                    {
                        return CreateFacilityStart;
                    }

                    public String GetImpersonate()
                    {
                        return Impersonate;
                    }

                    public String GetfacilityNavigation()
                    {
                        return facilityNavigation;
                    }

                    public String GetfacilitycreationStatus()
                    {
                        return facilitycreationStatus;
                    }

                    public String GetFacilityscreenshotName()
                    {
                        return FacilityScreenshot;
                    }


                    /******************************************************************************************
                     *                 BD_ValidateCreationOfNewPharmacyFormualry() Test Logs getters          *
                     ******************************************************************************************/

                    public String GetCreatePharmacyStart()
                    {
                        return CreatePharmacyStart;
                    }

                    public String GetpharmacycreationStatus()
                    {
                        return pharmacycreationStatus;
                    }

                    public String GetpharmacyNavigation()
                    {
                        return pharmacyNavigation;
                    }

                    public String GetPFscreenshotName()
                    {
                        return PharmacyScreenshot;
                    }


                    /******************************************************************************************
                     *                 BD_ValidateCreationOfNewAlignmentProject() Test Logs getters           *
                     ******************************************************************************************/

                    public String GetCreateProjectStart()
                    {
                        return CreateProjectStart;
                    }

                    public String GetAlignmentcreationStatus()
                    {
                        return AlignmentcreationStatus;
                    }

                    public String GetAlignmentNavigation()
                    {
                        return AlignmentNavigation;
                    }

                    public String GetAlignmentscreenshotName()
                    {
                        return AlignmentScreenshot;
                    }

                    /******************************************************************************************
                     *               BD_ValidateCreationOfNewAlignmentProjectDB() Test Logs getters           *
                     ******************************************************************************************/
                    public String GetStartDBValidation()
                    {
                        return DBvalidationStart ;
                    }

                    public String GetconnectDB()
                    {
                        return DBConnect;
                    }

                    public String Getconnecting()
                    {
                        return connecting;
                    }

                    public String GetConnectDone()
                    {
                        return connectComplete;
                    }

                    public String GetReadData()
                    {
                        return ReadData;
                    }

    }
}
