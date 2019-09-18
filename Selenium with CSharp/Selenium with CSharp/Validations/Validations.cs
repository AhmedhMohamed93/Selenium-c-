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
        readonly String launchStart = "Validation Of Launching BD Website";
        readonly String Navigation = "System Navigating now";
        readonly String LaunchStatus = "System Navigated successfully";


        /****************************************************************************************************
         *                                                                                                  *
         *                            BD_ValidateLaunchWebsite() Test Logs getters                          *
         *                                                                                                  *
         ****************************************************************************************************/

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


        /****************************************************************************************************
         *                                                                                                  *
         *                            BD_LoginSuccessfully() Test Log Strings                               *
         *                                                                                                  *
         ****************************************************************************************************/

        readonly String loginStart = "Validation Of Login successfully to BD Website";
        readonly String Logging = "System is Logging in now";


        /****************************************************************************************************
         *                                                                                                  *
         *                            BD_LoginSuccessfully() Test Logs getters                              *
         *                                                                                                  *
         ****************************************************************************************************/

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
            return LaunchStatus;
        }

        /****************************************************************************************************
         *                                                                                                  *
         *                        BD_ValidateCreationOfNewHealthSystem() Test Log Strings                   *
         *                                                                                                  *
         ****************************************************************************************************/

        readonly String CreateIDNStart = "Validation Of Create New HealthSystem";
        readonly String Launching = "System is navigated to BD website and logged in successfully";
        readonly String IDNNavigation = "System is navigated Health Systems Page";
        readonly String successfulCreationOfIDN = "New IDN is created successfully";
        readonly String CreationStatus = "New IDN is impersonated successfully";


        /****************************************************************************************************
         *                                                                                                  *
         *                            BD_LoginSuccessfully() Test Logs getters                              *
         *                                                                                                  *
         ****************************************************************************************************/

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

        /****************************************************************************************************
         *                                                                                                  *
         *                        BD_ValidateCreationOfNewFacility() Test Log Strings                       *
         *                                                                                                  *
         ****************************************************************************************************/

        readonly String CreateFacilityStart = "Validation Of Create New Facility";
        readonly String facilityNavigation = "System is navigated to Regions and Facilities successfully";
        readonly String facilitycreationStatus = "New Facility is created successfully";
        readonly String Impersonate = "The created IDN is impersonated successfully";



        /****************************************************************************************************
         *                                                                                                  *
         *                        BD_ValidateCreationOfNewFacility() Test Logs getters                      *
         *                                                                                                  *
         ****************************************************************************************************/

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

        /****************************************************************************************************
         *                                                                                                  *
         *                    BD_ValidateCreationOfNewPharmacyFormualry() Test Log Strings                  *
         *                                                                                                  *
         ****************************************************************************************************/

        readonly String CreatePharmacyStart = "Validation Of Create New Pharmacy Formulary";
        readonly String pharmacyNavigation = "System is navigated to Pharmacy Formularies Page successfully";
        readonly String pharmacycreationStatus = "New Pharmacy Formualry is created successfully";



        /****************************************************************************************************
         *                                                                                                  *
         *                    BD_ValidateCreationOfNewPharmacyFormualry() Test Logs getters                 *
         *                                                                                                  *
         ****************************************************************************************************/

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

        /****************************************************************************************************
         *                                                                                                  *
         *                    BD_ValidateCreationOfNewAlignmentProject() Test Log Strings                   *
         *                                                                                                  *
         ****************************************************************************************************/

        readonly String CreateProjectStart = "Validation Of Create New Alignment Project";
        readonly String AlignmentNavigation = "System is navigated to Alignment Projects Page successfully";
        readonly String AlignmentcreationStatus = "New Alignment Project is created successfully";



        /****************************************************************************************************
         *                                                                                                  *
         *                    BD_ValidateCreationOfNewAlignmentProject() Test Logs getters                  *
         *                                                                                                  *
         ****************************************************************************************************/

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
    }
}
