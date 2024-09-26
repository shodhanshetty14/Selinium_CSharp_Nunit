using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using System.Data.Common;

namespace NUnitSelenium.Selenium
{
    internal class DragAndDropExample
    {
        ChromeDriver driver;

        [SetUp]
        public void setUp()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/drag_and_drop");
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


            IWebElement source = driver.FindElement(By.Id("column-a"));
            IWebElement destination = driver.FindElement(By.Id("column-b"));

            //IWebElement source = driver.FindElement(By.XPath("//div[@id='column-a']"));
            //IWebElement destination = driver.FindElement(By.XPath("//div[@id='column-b']"));
            new Actions(driver).DragAndDrop(source, destination).Perform();

            Thread.Sleep(4000);
        }
    }
}
