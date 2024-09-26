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
    internal class WebTableAssignment2
    {
        ChromeDriver driver;

        [SetUp]
        public void setUp()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://rahulshettyacademy.com/AutomationPractice/");
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
            IWebElement table = driver.FindElement(By.ClassName("table-display"));

            List<IWebElement> tr = new List<IWebElement>(table.FindElements(By.XPath("//table[@class='table-display']/tbody/tr")));

            int rowCount = tr.Count();
            Console.WriteLine(rowCount + "row number");

            List<IWebElement> td = new List<IWebElement>(table.FindElements(By.XPath("//table[@class='table-display']/tbody/tr[1]/td")));

            int columnCount = td.Count();
            Console.WriteLine(columnCount + "Column number");

            IWebElement cellData = driver.FindElement(By.XPath("//table[@class='table-display']/tbody/tr[8]/td[2]"));
            string textData = cellData.Text;
            Console.WriteLine(cellData.Text);
            Assert.That(textData, Is.EqualTo("QA Expert Course :Software Testing + Bugzilla + SQL + Agile"));

            int cnt = 0;
            foreach (var i in table.FindElements(By.XPath("//table[@class='table-display']/tbody/tr")))
            {

                foreach (var j in i.FindElements(By.XPath($"//table[@class='table-display']/tbody/tr[{cnt++}]/td")))
                {
                    Console.Write(j.Text + " - ");
                }
                Console.WriteLine();
            }

            //Thread.Sleep(2000);
        }
    }
}

