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
    internal class DynamicWebElement
    {
        ChromeDriver driver;

        [SetUp]
        public void setUp()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.cavai.com/");
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
        public void FBUsernameAction()

        {
            IWebElement headerElement = driver.FindElement(By.XPath("//p[starts-with(text(),'Start having two-way conversations with your audiences on their terms.')]"));
            Assert.That(headerElement,Is.Not.Null);
            headerElement.Click();

            IWebElement paraTextElem = driver.FindElement(By.XPath("//p[contains(text(),\'The person who sees the ad steers the conversation ')]"));
            Assert.That(paraTextElem, Is.Not.Null);
            headerElement.Click();

            //IWebElement  = driver.FindElement(By.XPath("//p[starts-with(@class, 'CavaiFor_row__text_')]"));
            //Assert.That(paraTextElem, Is.Not.Null);
            //headerElement.Click();

            Thread.Sleep(2000);
        }
    }
}
