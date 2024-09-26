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
    internal class MultipleRadio
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

            Thread.Sleep(1000);
            IReadOnlyList<IWebElement> radioBoxes = driver.FindElements(By.XPath("//input[@type='radio']"));
            foreach (IWebElement i in radioBoxes)
            {
                Console.WriteLine(i.Text);
                i.Click();
                Thread.Sleep(1000);
            }
            Thread.Sleep(1000);
        }
    }
}
