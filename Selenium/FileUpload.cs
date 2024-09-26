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
    internal class FileUpload
    {
        ChromeDriver driver;

        [SetUp]
        public void setUp()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/upload");
            driver.Manage().Window.Maximize();

        }

        [TearDown]
        public void Teardown()
        {
            driver.Close();
        }

        [Test]
        public void FileUploadFunc()
        {

            IWebElement chooseFileButton = driver.FindElement(By.Id("file-upload"));
            chooseFileButton.SendKeys("C:\\Users\\shosh\\Pictures\\Screenshots\\Screenshot 2024-08-07 130616.png");

            IWebElement uploadButton = driver.FindElement(By.Id("file-submit"));
            uploadButton.Click();
            Thread.Sleep(3000);

            IWebElement fileUploadMessage = driver.FindElement(By.XPath("//h3[normalize-space()='File Uploaded!']"));
            string textMessage = fileUploadMessage.Text;
            Assert.That(textMessage, Is.EqualTo("File Uploaded!"));
        }
    }
}
