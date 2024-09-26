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
    internal class MultipleCheckBoxes
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
        public void MultipleCheckBox()
        {
            driver.Navigate().GoToUrl("https://rahulshettyacademy.com/AutomationPractice/");
            driver.Manage().Window.Maximize();

            Thread.Sleep(1000);
            IReadOnlyList<IWebElement> checkboxes = driver.FindElements(By.XPath("//input[@type='checkbox']"));
            foreach (IWebElement i in checkboxes)
            {
                Console.WriteLine(i.Text);
                i.Click();
                Thread.Sleep(2000);
            }
            Thread.Sleep(4000);
        }

    }
}
