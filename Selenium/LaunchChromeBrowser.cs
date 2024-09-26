using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnitSelenium.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSelenium.Selenium
{
    internal class LaunchChromeBrowser : Base
    {

        [Test]
        public void linksselection()
        {
            IReadOnlyList<IWebElement> downloadLink = driver.FindElements(By.TagName("a"));
            foreach (IWebElement i in downloadLink)
            {
                Console.WriteLine(i.Text + "URL is - " + i.GetAttribute("href"));
            }


        }

    }
}
