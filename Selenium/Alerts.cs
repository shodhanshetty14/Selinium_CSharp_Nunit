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
    internal class Alerts
    {
        ChromeDriver driver;

        [SetUp]
        public void setUp()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/javascript_alerts");
            driver.Manage().Window.Maximize();

        }

        [TearDown]
        public void Teardown()
        {
            driver.Close();
        }

        [Test]
        public void Alert()
        {
            IWebElement simpleAlert = driver.FindElement(By.XPath("//button[normalize-space()='Click for JS Alert']"));
            simpleAlert.Click();
            Thread.Sleep(2000);

            //switch to alert popUp
            IAlert alert = driver.SwitchTo().Alert();
            //Press OK button
            Thread.Sleep(2000);
            alert.Accept();

            Thread.Sleep(2000);
            IWebElement ConfirmationAlert = driver.FindElement(By.XPath("//button[normalize-space()='Click for JS Confirm']"));
            ConfirmationAlert.Click();
            Thread.Sleep(2000);
            alert.Dismiss();
            Thread.Sleep(2000);


            IWebElement PromptAlert = driver.FindElement(By.XPath("//button[normalize-space()='Click for JS Prompt']"));
            PromptAlert.Click();
            alert.SendKeys("Hello Worldd!!!");
            Thread.Sleep(2000);
            alert.Accept();
            Thread.Sleep(2000);
            


        }
    }
}
