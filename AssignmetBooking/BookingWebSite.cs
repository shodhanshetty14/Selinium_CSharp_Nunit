using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnitSelenium.Utilities;
using OpenQA.Selenium;

namespace NUnitSelenium.AssignmetBooking 
{
    internal class BookingWebSite : Base
    {
        [TestCase("mumbai")]
        public void  testcaseBooking(string location)
        {
            try
            {
                IWebElement closePopUpButton = driver.FindElement(By.XPath("//button[@aria-label='Dismiss sign-in info.']"));
                closePopUpButton.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("The Pop Up window did not appear this time");
            }

            IWebElement locationSelector = driver.FindElement(By.Name("ss"));
            locationSelector.SendKeys(location);
            Thread.Sleep(2000);
            IWebElement firstOptionResult = driver.FindElement(By.XPath("//li[@id='autocomplete-result-0']"));
            firstOptionResult.Click();
            Thread.Sleep(2000);

            IWebElement dateSelector = driver.FindElement(By.XPath("//span[contains(text(),'Check-in Date')]"));
            dateSelector.Click();
            Thread.Sleep(2000);

            IWebElement WHen = driver.FindElement(By.XPath("//*[@id=\"indexsearch\"]/div[2]/div/form/div[1]/div[2]/div/div/span[1]"));
            WHen.Click();
            Thread.Sleep(1000);
            IWebElement From = WHen.FindElement(By.XPath("//span[@aria-label='25 September 2024']"));
            From.Click();


            Thread.Sleep(5000);



            
        }
    }
}
