using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using NUnitSeleniumC_Training.Utilities;
using OfficeOpenXml.Style;

namespace NUnitSeleniumC_Training.DataDrivenTesting
{
    internal class TestParamExcel
    {
        [Test, TestCaseSource("GetTestData")]

        public void LoginTest(string username, string password)
        {
            Console.WriteLine(username + ":" + password);

        }

        public static IEnumerable<TestCaseData> GetTestData()
        {
            var columns = new List<string> { "username", "password" };

            return ExcelRead.GetTestDataFromExcel("C:\\Users\\masbh\\source\\repos\\NUnitSeleniumC#Training\\testdata.xlsx", "LoginTest", columns);
        }
    }
}