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
    internal class WebTable
    {
        ChromeDriver driver;

        [SetUp]
        public void setUp()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/tables");
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
            IWebElement table = driver.FindElement(By.Id("table1"));
            
            List<IWebElement> tr = new List<IWebElement>(table.FindElements(By.XPath("//table[@id='table1']/tbody/tr")));

            int rowCount = tr.Count();
            Console.WriteLine(rowCount + "row number");

            List<IWebElement> td = new List<IWebElement>(table.FindElements(By.XPath("//table[@id='table1']/tbody/tr[1]/td")));

            int columnCount = td.Count();
            Console.WriteLine(columnCount + "Column number");

            IWebElement cellData = driver.FindElement(By.XPath("//table[@id='table1']/tbody/tr[2]/td[2]"));
            string textData = cellData.Text;
            Console.WriteLine(cellData.Text);
            Assert.That(textData, Is.EqualTo("Frank"));

            List<IWebElement> allData = new List<IWebElement>(table.FindElements(By.XPath("//table[@id='table1']/tbody/tr/td")));

            //foreach (IWebElement element in allData)
            //{
            //    Console.WriteLine(element.Text);
            //}
            int cnt = 1;
            foreach (IWebElement element in allData)
            {
                Console.Write(element.Text + " - ");
                if(cnt == columnCount)
                {
                    cnt = 1;
                    Console.WriteLine();
                }
                else
                {
                    cnt++;
                }
            }




            Thread.Sleep(2000);
        }
    }
}
