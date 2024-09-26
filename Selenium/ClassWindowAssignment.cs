using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSelenium.Selenium
{
    internal class ClassWindowAssignment
    {
        ChromeDriver driver;

        [SetUp]
        public void setUp()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/windows");
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
        public void windowHandellingScenarios()
        {
            //fetch window handel of parent page!!
            string currWindow = driver.CurrentWindowHandle;

            //Console.WriteLine(currWindow);

            Assert.That(currWindow, Is.Not.Null);

            IWebElement windowInput = driver.FindElement(By.XPath("(//a[normalize-space()='Click Here'])[1]"));
            windowInput.Click();

            IList<string> winodowNames = new List<string>(driver.WindowHandles);

            //move the control to child window.
            driver.SwitchTo().Window(winodowNames[1]);

            string title = driver.Title;

            Assert.That(title, Is.EqualTo("New Window"));
            Thread.Sleep(4000);
            driver.Close();

            driver.SwitchTo().Window(winodowNames[0]);
            string Parenttitle = driver.Title;

            Assert.That(Parenttitle, Is.EqualTo("The Internet"));
            Thread.Sleep(4000);
            //Thread.Sleep(4000);
        }
    }
}
