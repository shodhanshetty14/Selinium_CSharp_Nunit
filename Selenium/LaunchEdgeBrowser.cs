using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSelenium.Selenium
{
    internal class LaunchEdgeBrowser
    {

        [SetUp]
        public void startBrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
            EdgeDriver driver = new EdgeDriver();

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
