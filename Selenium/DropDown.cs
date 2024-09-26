using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSelenium.Selenium
{
    internal class DropDown
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
        public void DropDownSelect()
        {
            driver.Navigate().GoToUrl("https://rahulshettyacademy.com/AutomationPractice/");
            driver.Manage().Window.Maximize();

            IWebElement dropDown = driver.FindElement(By.Id("dropdown-class-example"));
            Assert.That(dropDown, Is.Not.Null);
            var select = new SelectElement(dropDown);

            //select by visble text
            select.SelectByText("Option2");
            Thread.Sleep(2000);

            //Select by index
            select.SelectByIndex(1);
            Thread.Sleep(2000);

            //select by attribute value
            select.SelectByValue("option3");

        }
    }
}
