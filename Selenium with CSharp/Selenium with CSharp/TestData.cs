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
            excel.Workbook xworkbook = xapp.Workbooks.Open("C:\\Users\\ahmed.mohamed\\Documents\\GitHub\\Selenium-C-POC\\Create New Smart Alignment Project\\POC\\DattaDriiven");
            excel.Worksheet xworksheet = xworkbook.Sheets[1];
            excel.Range xrange = xworksheet.UsedRange;
            return xrange.Cells[x][y].value2;
        }

    }
}
