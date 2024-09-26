using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using AngleSharp;
using System.Configuration;

namespace NUnitSelenium.Utilities
{
    internal class Base
    {
        public IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {

            string browserName = ConfigurationManager.AppSettings["browser"];
            InitBrowser(browserName);
            //driver.Navigate().GoToUrl("https://www.booking.com/");

            driver.Navigate().GoToUrl("https://parabank.parasoft.com/parabank/register.html");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

        }

        public void InitBrowser(string browserName)
        {
            switch (browserName)
            {
                case "Firefox":
                    new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
                    driver = new FirefoxDriver();
                    break;
                case "Edge":
                    new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
                    driver = new EdgeDriver();
                    break;
                case "Chrome":
                    new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                    driver = new ChromeDriver();
                    break;
            }

        }


        [TearDown]
        public void tearDownBrowser()
        {
            Thread.Sleep(3000);
            driver.Close();
            
            //driver.Close();
            //driver.Quit();
            //driver.Dispose();
            //driver = null;
        }
    }
}
