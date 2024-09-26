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
    internal class CheckBox
    {
        ChromeDriver driver;

        [SetUp]
        public void setUp()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();

        }

        [TearDown]
        public void Teardown()
        {
            driver.Close();
        }

        [Test]
        public void NavigationalCommand()
        {
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/checkboxes");
            driver.Manage().Window.Maximize();

            IWebElement checkbox2 = driver.FindElement(By.XPath("(//input[@type='checkbox'])[1]"));
            checkbox2.Click();

            Thread.Sleep(4000);
        }
    }
}
