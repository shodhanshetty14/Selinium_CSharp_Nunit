using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSelenium.NUnitTest
{
    [Allure.NUnit.AllureNUnit]
    [TestFixture, Category("Testing...........")]
    internal class CategoryTesting
    {
        [Test, Category("Regression")]
        public void Login()
        {
            Console.WriteLine("Login Successful");
        }

        [Test, Category("Sanity")]
        public void Products()
        {
            Console.WriteLine("Products Display Successful.");
        }

        [Test, Ignore("Defect Id123")]
        public void AddToCart()
        {
            Console.WriteLine("Added item to the cart.");
        }
    }
}
