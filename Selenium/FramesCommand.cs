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
    internal class FramesCommand
    {
        ChromeDriver driver;

        [SetUp]
        public void setUp()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://jqueryui.com/checkboxradio/");
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
            IWebElement frame1 = driver.FindElement(By.XPath("//iframe[@class='demo-frame']"));

            //select frame using the xpath of frame
            driver.SwitchTo().Frame(frame1);

            //select frame using the index
            //driver.SwitchTo().Frame(1);

            //select frame using ID or name
            //driver.SwitchTo().Frame("class-name-or-id-or-name-goes-here");

            IWebElement newYorkRadioBtn = driver.FindElement(By.XPath("(//label[normalize-space()='New York'])[1]"));
            newYorkRadioBtn.Click();

            //go back to the original frame 
            driver.SwitchTo().DefaultContent();

            Thread.Sleep(4000);
        }
    }
}
