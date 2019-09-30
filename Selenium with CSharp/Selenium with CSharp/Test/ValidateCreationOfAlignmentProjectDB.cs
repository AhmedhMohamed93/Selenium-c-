using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using AventStack.ExtentReports;

namespace Selenium_with_CSharp.Test
{
    class ValidateCreationOfAlignmentProjectDB : TestBase
    {
        /****************************************************************************************************
         *                               Declaration of classes Objects                                     *
         ****************************************************************************************************/
        readonly Validations validStrings = new Validations();


        /****************************************************************************************************
         *                                                                                                  *
         *   Test Method Name : BD_ValidateCreationOfNewAlignmentProjectDB()                                *
         *   Inputs           : String PName                                                             	*
         *   Objective        : This Test validates creation of New Alignment PRoject within the            *
         *                    : created Health System in the BackEnd [DataBase]                             *
         *                                                                                                  *
         * @throws Throwable 																				*
         ****************************************************************************************************/
        [Test]
        [TestCaseSource(typeof(TestBase), "BrowserToRunWith")]
        [Obsolete]
        public void BD_ValidateCreationOfNewAlignmentProjectDB(String browserName)
        {
            Setup(browserName);
            test = extent.CreateTest(validStrings.GetconnectDB());
            String con = "Data Source=SD-KP-TSASUP01.CFNP.LOCAL\\KP;Initial Catalog=CommonFormulary;User ID=CommonFormularyAppUser;Password=CommonFormularyAppUser";
            try
            {
                SqlConnection connection = new SqlConnection(con);
                test.Log(Status.Info, validStrings.Getconnecting());
                connection.Open();
                test.Log(Status.Info, validStrings.GetConnectDone());
                test.Log(Status.Info, validStrings.GetReadData());
                SqlCommand command = new SqlCommand("SELECT *  FROM [EF].SmartPumpAlignmentProject  where ProjectName = @dataquery", connection);
                command.Parameters.Add(new SqlParameter("dataquery", dataDriven.GetAlignmentProjectName()));

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        String data = String.Format("{0},{1}", reader[0], reader[1]);
                        int position = data.IndexOf(",");
                        Assert.AreEqual("Epic101_AP002", data.Substring(position + 1));
                        Console.WriteLine(data.Substring(position + 1));
                    }
                }
            }catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}


