using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSelenium.NUnitTest
{
    [Allure.NUnit.AllureNUnit]
    internal class AllureTestReportGeneration
    {
        [Test]
        public void Login()
        {
            Console.WriteLine("Login Successful");
        }

        [Test]
        public void Products()
        {
            Console.WriteLine("Products Display Successful.");
        }

        [Test]
        public void AddToCart()
        {
            Console.WriteLine("Added item to the cart.");
        }
    }
}
