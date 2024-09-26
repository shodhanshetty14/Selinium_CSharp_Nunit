using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSelenium.Selenium
{
    internal class CommandClickAndHold
    {
        ChromeDriver driver;

        [SetUp]
        public void setUp()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.amazon.in/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }

        [TearDown]
        public void Teardown()
        {
            Thread.Sleep(2000);
            driver.Close();
        }

        [Test]
        public void ActionsCommmand()
        {


            IWebElement primeElem = driver.FindElement(By.XPath("//span[normalize-space()='Prime']"));

            new Actions(driver).ClickAndHold(primeElem).Perform();
            Thread.Sleep(4000);

            Assert.That(primeElem.Text, Is.EqualTo("Prime"));
        }
    }
}
