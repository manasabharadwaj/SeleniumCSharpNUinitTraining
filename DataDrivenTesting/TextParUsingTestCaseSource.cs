using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumC_Training.DataDrivenTesting
{
    internal class TextParUsingTestCaseSource
    {
        [Test, TestCaseSource("GetTestData")]
        public void LoginTest(string user, string password)
        {
            Console.WriteLine(user + ":" + password);
        }
        public static IEnumerable<TestCaseData> GetTestData()
        {
            yield return new TestCaseData ("abc.com", "ghhjj");
            yield return new TestCaseData("ghh.com", "sdhjj");
            yield return new TestCaseData("mkk.com", "isuyj");
        }
    }
}
