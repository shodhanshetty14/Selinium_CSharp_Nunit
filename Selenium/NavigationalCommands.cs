using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSelenium.Selenium
{
    internal class NavigationalCommands
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
        public void NavigationalCommand()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            driver.Manage().Window.Maximize();

            Thread.Sleep(3000);
            driver.Navigate().Back();
            Thread.Sleep(4000);
            driver.Navigate().Forward();
            Thread.Sleep(4000);
            driver.Navigate().Refresh();
            Thread.Sleep(4000);

        }
    }
}
