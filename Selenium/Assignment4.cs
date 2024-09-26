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
    internal class Assignment4
    {
        ChromeDriver driver;

        [SetUp]
        public void setUp()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.makemytrip.com/");
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
        public void testCases()
        {
            IWebElement closeButton = driver.FindElement(By.ClassName("commonModal__close"));
            closeButton.Click();
            Thread.Sleep(2000);

            IWebElement dateSelector = driver.FindElement(By.XPath("//span[normalize-space()='Departure']"));
            dateSelector.Click();
            Thread.Sleep(2000);

            IWebElement date26 = driver.FindElement(By.XPath("(//p[contains(text(),'26')])[1]"));
            Console.WriteLine(date26.Text);
            string date = date26.Text;
            date26.Click();
            Assert.That(date, Is.EqualTo("26"));
            Thread.Sleep(2000);

            IWebElement fareSelection = driver.FindElement(By.XPath("(//div[normalize-space()='Student'])[1]"));

            fareSelection.Click();
            Thread.Sleep(2000);

            IWebElement searchButton = driver.FindElement(By.XPath("(//a[normalize-space()='Search'])[1]"));
            searchButton.Click();
            Thread.Sleep(4000);
/*
            IWebElement studentOkButton = driver.FindElement(By.XPath("//button[@class='okayButton fontSize16']"));
            studentOkButton.Click();
            Thread.Sleep(2000);

            IWebElement filghtTextSpan = driver.FindElement(By.XPath("(//span[contains(text(),'Flights from')])[1]"));
            string flightText = filghtTextSpan.Text;
            Assert.That(flightText, Is.EqualTo("Flights from New Delhi to Bengaluru"));
            Thread.Sleep(2000);*/




        }

    }
}
