using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace NUnitSelenium.ParallelExec
{
    [Parallelizable]
    internal class ParallelExecutionUsingTestParms
    {

        [Parallelizable(ParallelScope.Children)]
        [Test, TestCaseSource(nameof(GetTestData))]
        public void testCaseLoginInvalid(string username, string password)
        {
            DateTime now = DateTime.Now;
            string time = now.ToString("yyyy-mm-dd-_HH-mm-ss");
            Console.WriteLine(username + ":" + password + "Time taken - " + time);

                Thread.Sleep(2000);

        }
        public static IEnumerable<TestCaseData> GetTestData()
        {
            yield return new TestCaseData("xyz.com", "gfyhjbn");
            yield return new TestCaseData("abc.com", "ghhff");
            yield return new TestCaseData("dhj.com", "gvhb");

        }
    }
}
