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
    internal class Assignment3
    {
        ChromeDriver driver;

        [SetUp]
        public void setUp()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void Teardown()
        {
            driver.Close();
        }

        [Test]
        public void testCases()
        {
            Thread.Sleep(2000);
            IWebElement userName = driver.FindElement(By.Id("user-name"));
            userName.SendKeys("standard_user");

            IWebElement Password = driver.FindElement(By.Id("password"));
            Password.SendKeys("secret_sauce");

            IWebElement submitButton = driver.FindElement(By.Id("login-button"));
            //var submitButton = driver.FindElement(By.Id("login-button"));    //this also works
            submitButton.Click();

            Thread.Sleep(2000);

            IWebElement addToCartButton = driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack"));
            addToCartButton.Click();
            Thread.Sleep(2000);

            IWebElement cartButton = driver.FindElement(By.ClassName("shopping_cart_link"));
            cartButton.Click();
            Thread.Sleep(2000);

            IWebElement checkoutButton = driver.FindElement(By.Id("checkout"));
            checkoutButton.Click();
            Thread.Sleep(2000);

            IWebElement firstNameInput = driver.FindElement(By.Id("first-name"));
            firstNameInput.SendKeys("abc");
            Thread.Sleep(2000);

            IWebElement lastNameInput = driver.FindElement(By.Id("last-name"));
            lastNameInput.SendKeys("xyz");
            Thread.Sleep(2000);

            IWebElement postalCodeInput = driver.FindElement(By.Name("postalCode"));
            postalCodeInput.SendKeys("560900");
            Thread.Sleep(2000);

            IWebElement continueButton = driver.FindElement(By.Id("continue"));
            continueButton.Click();

            IWebElement finishButton = driver.FindElement(By.Id("finish"));
            finishButton.Click();
            Thread.Sleep(2000);

            IWebElement thankYouSection = driver.FindElement(By.ClassName("complete-header"));
            Console.WriteLine(thankYouSection.Text);
            string expectedText = thankYouSection.Text;

            Assert.That(expectedText, Is.EqualTo("Thank you for your order!"));
            Thread.Sleep(2000);


        }


    }
}
