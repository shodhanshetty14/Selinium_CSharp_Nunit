using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSelenium.Selenium
{
    internal class Login
    {
       ChromeDriver driver;
        [SetUp]
        public void startBrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void tearDown()
        {
            driver.Close();
        }


        [Test]
        public void testCaseLogin()
        {

            Thread.Sleep(2000);

            IWebElement UserName = driver.FindElement(By.Name("username"));
            UserName.SendKeys("Admin");

            IWebElement Password = driver.FindElement(By.Name("password"));
            Password.SendKeys("admin123");

            IWebElement LoginButton = driver.FindElement(By.XPath("//Button[@type='submit']"));
            LoginButton.Click();

        }
    }
}
