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
    internal class Assignment2
    {
        ChromeDriver driver;


        [SetUp]
        public void setUp()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demowebshop.tricentis.com/register");
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void tearDown()
        {
            driver.Close();
        }

        [Test]
        public void testcase1()
        {
            Thread.Sleep(3000);

            //gender radio male button click....
            driver.FindElement(By.Id("gender-male")).Click();

            IWebElement FirstName = driver.FindElement(By.Id("FirstName"));
            FirstName.SendKeys("abc");

            IWebElement LastName = driver.FindElement(By.Id("LastName"));
            LastName.SendKeys("xyz");

            IWebElement email = driver.FindElement(By.Id("Email"));
            email.SendKeys("abcxyz1@gmail.com");

            IWebElement password = driver.FindElement(By.Id("Password"));
            password.SendKeys("abcxyz");

            IWebElement ConfirmPassword = driver.FindElement(By.Id("ConfirmPassword"));
            ConfirmPassword.SendKeys("abcxyz");

            //Register button 
            driver.FindElement(By.Id("register-button")).Click();

            Thread.Sleep(2000);
        }
    }
}
