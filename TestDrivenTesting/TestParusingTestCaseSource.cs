using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace NUnitSelenium.TestDrivenTesting
{
    internal class TestParusingTestCaseSource
    {

        [Test, TestCaseSource(nameof(GetTestData))]
        public void testCaseLogin(string username, string password)
        {
            Console.WriteLine(username + " - " + password);
        }

        public static IEnumerable<TestCaseData> GetTestData()
        {
            yield return new TestCaseData("xyz.com", "gfyhjbn");
            yield return new TestCaseData("abc.com", "ghhff");
            yield return new TestCaseData("dhj.com", "gvhb");

        }
    }
}
