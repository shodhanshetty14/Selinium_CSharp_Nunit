using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Support.Extensions;

namespace NUnitSelenium.Selenium
{
    internal class TakeScreenShot
    {
        ChromeDriver driver;

        [SetUp]
        public void setUp()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.selenium.dev/");
            driver.Manage().Window.Maximize();

        }

        [TearDown]
        public void Teardown()
        {
            driver.Close();
        }

        [Test]
        public void takeScreenshot()
        {
            
            Thread.Sleep(3000);
            Screenshot ss = driver.TakeScreenshot();
            ss.SaveAsFile("C:\\Users\\shosh\\Downloads\\ss.png");
        }
    }
}
