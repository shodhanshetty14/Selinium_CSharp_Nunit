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
    internal class Locators
    {
        ChromeDriver driver;
        [SetUp]
        public void startBrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://automationexercise.com/contact_us");
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void tearDown()
        {
            driver.Close();
        }

        [Test]
        public void testCase1()
        {

            Thread.Sleep(2000);
            IWebElement name = driver.FindElement(By.Name("name"));
            name.SendKeys("xyz");

            IWebElement email = driver.FindElement(By.CssSelector("input[placeholder='Email']"));
            email.SendKeys("xyz@gmail.com");

            IWebElement subject = driver.FindElement(By.XPath("//input[@placeholder='Subject']"));
            subject.SendKeys("Hello how are you?");

            IWebElement message = driver.FindElement(By.Id("message"));
            message.SendKeys("im good how are youuu??");

            IWebElement submit = driver.FindElement(By.XPath("//input[contains(@type,'submit')]"));
            submit.Click();

        }

    }
}
