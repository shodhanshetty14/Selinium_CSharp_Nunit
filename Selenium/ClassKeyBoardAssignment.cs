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
    internal class ClassKeyBoardAssignment
    {
        ChromeDriver driver;

        [SetUp]
        public void setUp()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.facebook.com/login/");
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


            new Actions(driver).KeyDown(Keys.Shift).SendKeys("abcd2gmail").KeyUp(Keys.Shift).SendKeys(".").KeyDown(Keys.Shift).SendKeys("com").KeyUp(Keys.Shift).KeyDown(Keys.Tab).KeyUp(Keys.Tab).KeyDown(Keys.Shift).SendKeys("xyz2").KeyUp(Keys.Shift).SendKeys("1234").Perform();

            //new Actions(driver).KeyDown(Keys.Shift).SendKeys("abcd2gmail").KeyUp(Keys.Shift).SendKeys(".").KeyDown(Keys.Shift).SendKeys("com").KeyUp(Keys.Shift).KeyDown(Keys.Tab).KeyUp(Keys.Tab).

            //new Actions(driver).KeyDown(Keys.Shift).SendKeys("xyz2").KeyUp(Keys.Shift).SendKeys("1234").Perform();


            Thread.Sleep(2000);
        }

    }
}
