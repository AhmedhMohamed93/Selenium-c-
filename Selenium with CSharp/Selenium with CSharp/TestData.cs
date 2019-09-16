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
       public String excelSetup(int x, int y)
        {
            excel.Application xapp = new excel.Application();
            excel.Workbook xworkbook = xapp.Workbooks.Open("C:\\Users\\Ahmed.Mohamed\\Documents\\GitHub\\Selenium-c-\\Selenium with CSharp\\Selenium with CSharp\\TestData\\TestDataDriven");
            excel.Worksheet xworksheet = xworkbook.Sheets[1];
            excel.Range xrange = xworksheet.UsedRange;
            return xrange.Cells[x][y].value2;
        }

        public String getUserName()
        {
            return excelSetup(2, 1);
        }

        public String getUserPassword()
        {
            return excelSetup(2, 2);
        }

        public String getIDNName()
        {
            return excelSetup(1, 5);
        }

        public String getiDNID()
        {
            return excelSetup(2, 5);
        }

        public String getFacilityName()
        {
            return excelSetup(3, 5);
        }

        public String getFacilityID()
        {
            return excelSetup(4, 5);
        }

        public String getPharmacyFormularyName()
        {
            return excelSetup(5, 5);
        }

        public String getPharmacyFormularyID()
        {
            return excelSetup(6, 5);
        }

        public String getPFvendor()
        {
            return excelSetup(7, 5);
        }

        public String getAlignmentProjectName()
        {
            return excelSetup(8, 5);
        }

    }
}
