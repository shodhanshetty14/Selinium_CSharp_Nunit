using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSelenium.Selenium
{
    internal class BrowserCommands
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
        public void testCases()
        {
            //GetUrl method of browser
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");

            //GetTitle command;
            var title = driver.Title;
            Console.WriteLine(title);

            //Current url method
            var currUrl = driver.Url;
            Console.WriteLine(currUrl);

            //get page source (get the full html of the page.!!
            var pageSource = driver.PageSource;
            Console.WriteLine(pageSource);

        }
    }
}
