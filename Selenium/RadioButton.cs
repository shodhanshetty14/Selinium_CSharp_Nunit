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
    internal class RadioButton
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
            driver.Navigate().GoToUrl("https://rahulshettyacademy.com/AutomationPractice/");
            driver.Manage().Window.Maximize();

            IWebElement radio1 = driver.FindElement(By.XPath("(//input[@type='radio'])[1]"));
            radio1.Click();
            Thread.Sleep(1000);

        }
    }
}
