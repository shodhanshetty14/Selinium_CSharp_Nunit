using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnitSelenium.Utilities;
using OpenQA.Selenium;

namespace NUnitSelenium.ParallelExec
{
    [Parallelizable]
    internal class ParallelExecutionWithWebElements : Base
    {

        [Parallelizable(ParallelScope.Children)]
        [Test, TestCaseSource(nameof(GetTestData))]
        public void testCaseLoginInvalid(string username, string password)
        {
            DateTime now = DateTime.Now;
            string time = now.ToString("yyyy-mm-dd-_HH-mm-ss");
            Console.WriteLine(username + ":" + password + "Time taken - " + time);

            Thread.Sleep(2000);


            Thread.Sleep(2000);

            IWebElement UserName = driver.FindElement(By.Name("username"));
            UserName.SendKeys(username);

            IWebElement Password = driver.FindElement(By.Name("password"));
            Password.SendKeys(password);

            IWebElement LoginButton = driver.FindElement(By.XPath("//Button[@type='submit']"));
            LoginButton.Click();

            Thread.Sleep(2000);

            IWebElement errorMessage = driver.FindElement(By.XPath("(//p[@class='oxd-text oxd-text--p oxd-alert-content-text'])[1]"));
            Assert.That(errorMessage.Text, Is.EqualTo("Invalid credentials"));

        }
        public static IEnumerable<TestCaseData> GetTestData()
        {
            yield return new TestCaseData("xyz.com", "gfyhjbn");
            yield return new TestCaseData("abc.com", "ghhff");
            yield return new TestCaseData("dhj.com", "gvhb");

        }
    }
}
