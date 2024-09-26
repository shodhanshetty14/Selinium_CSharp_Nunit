using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSelenium.Selenium
{
    internal class Assignment1
    {
        ChromeDriver driver;

        [SetUp]
        public void setUp()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void Teardown()
        {
            driver.Close();
        }

        [Test]
        public void testCases()
        {
            Thread.Sleep(2000);
            IWebElement userName = driver.FindElement(By.Id("user-name"));
            userName.SendKeys("standard_user");

            IWebElement Password = driver.FindElement(By.Id("password"));
            Password.SendKeys("secret_sauce");

            IWebElement submitButton = driver.FindElement(By.Id("login-button"));
            //var submitButton = driver.FindElement(By.Id("login-button"));    //this also works
            submitButton.Click();

            Thread.Sleep(2000);
        }

        

    }
}
