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
    internal class KeyBoardActionCommands
    {
        ChromeDriver driver;

        [SetUp]
        public void setUp()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.selenium.dev/selenium/web/single_text_input.html");
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
        public void KeysDownAction()
        {

            new Actions(driver).KeyDown(Keys.Shift).SendKeys("a").Perform();

            Thread.Sleep(2000);
        }
        [Test]
        public void KeysUpAction()
        {

            new Actions(driver).KeyDown(Keys.Shift).SendKeys("a").KeyUp(Keys.Shift).SendKeys("ab").Perform();
            Thread.Sleep(2000);
        }

        [Test]
        public void CopyAndPasteActions()
        {

        }
    }
}
