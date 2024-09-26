using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSelenium.NUnitTest
{
    [Allure.NUnit.AllureNUnit]
    internal class TestOrders
    {

        [Test, Order(2)]
        public void Login()
        {
            Console.WriteLine("Login Successful");
        }

        [Test,Order(3)]
        public void Products()
        {
            Console.WriteLine("Products Display Successful.");
        }

        [Test, Order(1)]
        public void AddToCart()
        {
            Console.WriteLine("Added item to the cart.");
        }
    }
}
