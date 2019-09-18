using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using excel = Microsoft.Office.Interop.Excel;


namespace Selenium_with_CSharp
{
    public class TestData
    {
       public String ExcelSetup(int x, int y)
        {
            excel.Application xapp = new excel.Application();
            excel.Workbook xworkbook = xapp.Workbooks.Open("C:\\Users\\Ahmed.Mohamed\\Documents\\GitHub\\Selenium-c-\\Selenium with CSharp\\Selenium with CSharp\\DataDriven\\Data1");
            excel.Worksheet xworksheet = xworkbook.Sheets[1];
            excel.Range xrange = xworksheet.UsedRange;
            return xrange.Cells[x][y].value2;
        }

        public String GetUserName()
        {
            return ExcelSetup(2, 1);
        }

        public String GetUserPassword()
        {
            return ExcelSetup(2, 2);
        }

        public String GetIDNName()
        {
            return ExcelSetup(1, 5);
        }

        public String GetiDNID()
        {
            return ExcelSetup(2, 5);
        }

        public String GetFacilityName()
        {
            return ExcelSetup(3, 5);
        }

        public String GetFacilityID()
        {
            return ExcelSetup(4, 5);
        }

        public String GetPharmacyFormularyName()
        {
            return ExcelSetup(5, 5);
        }

        public String GetPharmacyFormularyID()
        {
            return ExcelSetup(6, 5);
        }

        public String GetPFvendor()
        {
            return ExcelSetup(7, 5);
        }

        public String GetAlignmentProjectName()
        {
            return ExcelSetup(8, 5);
        }

    }
}
