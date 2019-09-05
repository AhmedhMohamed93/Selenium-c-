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
         *                            BD_ValidateLaunchWebsite() Test Log Strings                           *
         *                                                                                                  *
         ****************************************************************************************************/
        String launchStart = "Validation Of Launching BD Website";
        String Navigation = "System Navigating now";
        String LaunchStatus = "System Navigated successfully";


        /****************************************************************************************************
         *                                                                                                  *
         *                            BD_ValidateLaunchWebsite() Test Logs getters                          *
         *                                                                                                  *
         ****************************************************************************************************/

        public String getlaunchStart()
        {
            return launchStart;
        }

        public String getnavigationString()
        {
            return Navigation;
        }

        public String getlaunchStatus()
        {
            return LaunchStatus;
        }


        /****************************************************************************************************
         *                                                                                                  *
         *                            BD_LoginSuccessfully() Test Log Strings                               *
         *                                                                                                  *
         ****************************************************************************************************/

        String loginStart = "Validation Of Login successfully to BD Website";
        String Logging = "System is Logging in now";


        /****************************************************************************************************
         *                                                                                                  *
         *                            BD_LoginSuccessfully() Test Logs getters                              *
         *                                                                                                  *
         ****************************************************************************************************/

        public String getloginStart()
        {
            return loginStart;
        }

        public String getlogging()
        {
            return Logging;
        }

        public String getloginStatus()
        {
            return LaunchStatus;
        }

        /****************************************************************************************************
         *                                                                                                  *
         *                        BD_ValidateCreationOfNewHealthSystem() Test Log Strings                   *
         *                                                                                                  *
         ****************************************************************************************************/

        String CreateIDNStart = "Validation Of Create New HealthSystem";
        String Launching = "System is navigated to BD website and logged in successfully";
        String IDNNavigation = "System is navigated Health Systems Page";
        String successfulCreationOfIDN = "New IDN is created successfully";
        String CreationStatus = "New IDN is impersonated successfully";


        /****************************************************************************************************
         *                                                                                                  *
         *                            BD_LoginSuccessfully() Test Logs getters                              *
         *                                                                                                  *
         ****************************************************************************************************/

        public String getCreateIDNStart()
        {
            return CreateIDNStart;
        }

        public String getLaunching()
        {
            return Launching;
        }

        public String getIDNNavigation()
        {
            return IDNNavigation;
        }

        public String getsuccessfulCreationOfIDN()
        {
            return successfulCreationOfIDN;
        }

        public String getCreationStatus()
        {
            return CreationStatus;
        }

        /****************************************************************************************************
         *                                                                                                  *
         *                        BD_ValidateCreationOfNewFacility() Test Log Strings                       *
         *                                                                                                  *
         ****************************************************************************************************/

        String CreateFacilityStart = "Validation Of Create New Facility";
        String facilityNavigation = "System is navigated to Regions and Facilities successfully";
        String facilitycreationStatus = "New Facility is created successfully";
        String Impersonate = "The created IDN is impersonated successfully";



        /****************************************************************************************************
         *                                                                                                  *
         *                        BD_ValidateCreationOfNewFacility() Test Logs getters                      *
         *                                                                                                  *
         ****************************************************************************************************/

        public String getCreateFacilityStart()
        {
            return CreateFacilityStart;
        }

        public String getImpersonate()
        {
            return Impersonate;
        }

        public String getfacilityNavigation()
        {
            return facilityNavigation;
        }

        public String getfacilitycreationStatus()
        {
            return facilitycreationStatus;
        }

        /****************************************************************************************************
         *                                                                                                  *
         *                    BD_ValidateCreationOfNewPharmacyFormualry() Test Log Strings                  *
         *                                                                                                  *
         ****************************************************************************************************/

        String CreatePharmacyStart = "Validation Of Create New Pharmacy Formulary";
        String pharmacyNavigation = "System is navigated to Pharmacy Formularies Page successfully";
        String pharmacycreationStatus = "New Pharmacy Formualry is created successfully";



        /****************************************************************************************************
         *                                                                                                  *
         *                    BD_ValidateCreationOfNewPharmacyFormualry() Test Logs getters                 *
         *                                                                                                  *
         ****************************************************************************************************/

        public String getCreatePharmacyStart()
        {
            return CreatePharmacyStart;
        }

        public String getpharmacycreationStatus()
        {
            return pharmacycreationStatus;
        }

        public String getpharmacyNavigation()
        {
            return pharmacyNavigation;
        }

        /****************************************************************************************************
         *                                                                                                  *
         *                    BD_ValidateCreationOfNewAlignmentProject() Test Log Strings                   *
         *                                                                                                  *
         ****************************************************************************************************/

        String CreateProjectStart = "Validation Of Create New Alignment Project";
        String AlignmentNavigation = "System is navigated to Alignment Projects Page successfully";
        String AlignmentcreationStatus = "New Alignment Project is created successfully";



        /****************************************************************************************************
         *                                                                                                  *
         *                    BD_ValidateCreationOfNewAlignmentProject() Test Logs getters                  *
         *                                                                                                  *
         ****************************************************************************************************/

        public String getCreateProjectStart()
        {
            return CreateProjectStart;
        }

        public String getAlignmentcreationStatus()
        {
            return AlignmentcreationStatus;
        }

        public String getAlignmentNavigation()
        {
            return AlignmentNavigation;
        }
    }
}
