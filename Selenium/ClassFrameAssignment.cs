using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Interactions;

namespace NUnitSelenium.Selenium
{
    internal class ClassFrameAssignment
    {
        ChromeDriver driver;

        [SetUp]
        public void setUp()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/iframe");
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
            IWebElement frame1 = driver.FindElement(By.Id("mce_0_ifr"));

            //select frame using the xpath of frame
            driver.SwitchTo().Frame(frame1);

            //select frame using the index
            //driver.SwitchTo().Frame(1);

            //select frame using ID or name
            //driver.SwitchTo().Frame("class-name-or-id-or-name-goes-here");

            IWebElement textArea = driver.FindElement(By.XPath("//p[normalize-space()='Your content goes here.']"));
                textArea.Clear();   

            textArea.SendKeys("hello Everyone how are you!!!");

            //go back to the original frame 
            driver.SwitchTo().DefaultContent();

            Thread.Sleep(4000);
        }
    }
}
