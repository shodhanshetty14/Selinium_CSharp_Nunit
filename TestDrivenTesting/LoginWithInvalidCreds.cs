using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnitSelenium.Utilities;
using OpenQA.Selenium;

namespace NUnitSelenium.TestDrivenTesting
{

    internal class LoginWithInvalidCreds:Base
    {

        [TestCase("abc.com", "ghhff")]
        [TestCase("xyz.com", "gfyhjbn")]
        [TestCase("dhj.com", "gvhb")]
       
        public void testCaseLoginInvalid(string username, string password)
        {
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            driver.Manage().Window.Maximize();

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
    }
}
