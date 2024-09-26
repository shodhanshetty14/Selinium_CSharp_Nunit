using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSelenium.NUnitTest
{
    [Allure.NUnit.AllureNUnit]
    internal class FactorialUnitTesting
    {
        public Factorial fc;
        [SetUp]
        public void Initialization()
        {
            fc = new Factorial();
        }

        [Test]
        public void FactorialTestData()
        {
            int f1 = fc.FactorialNum(5);
            int f2  = fc.FactorialNum(2);
            //Assert.AreEqual(120, f1);
            //Assert.AreEqual(2, f2);

        }

    }
}
