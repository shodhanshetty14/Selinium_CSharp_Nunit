using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSelenium.Selenium
{
    internal class VerticalScrool
    {
        ChromeDriver driver;

        [SetUp]
        public void setUp()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.selenium.dev/downloads");
            driver.Manage().Window.Maximize();

        }

        [TearDown]
        public void Teardown()
        {
            driver.Close();
        }

        [Test]
        public void scroll()
        {
            Thread.Sleep(3000);

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            js.ExecuteScript("window.scrollBy(0, 800)", "");


            Thread.Sleep(3000);

            js.ExecuteScript("window.scrollBy(0, -300)", "");
            Thread.Sleep(3000);


            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)"); 
            Thread.Sleep(3000);



        }
    }
}
