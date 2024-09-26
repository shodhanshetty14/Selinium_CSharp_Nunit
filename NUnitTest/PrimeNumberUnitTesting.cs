using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSelenium.NUnitTest
{
    [Allure.NUnit.AllureNUnit]
    internal class PrimeNumberUnitTesting
    {
        public PrimeNumber pn;
        [SetUp]
        public void Initilization()
        {
            pn = new PrimeNumber();
        }

        [Test]
        public void PrimeNumberTest()
        {
            bool p1 = pn.IsPrimeNumber(7);
            bool p2 = pn.IsPrimeNumber(8);

            //Assert.AreEqual(true, p1);
            //Assert.AreEqual(false, p2);
        }
    }
}
