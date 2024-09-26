using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSelenium.Selenium
{
    internal class LaunchFirefoxBrowser
    {

        [SetUp]
        public void startBrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
            FirefoxDriver driver = new FirefoxDriver();

            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");


        }


        [Test]
        public void testCase1()
        {

        }

        [TearDown]
        public void tearDownBrowser()
        {

        }

    }
}
