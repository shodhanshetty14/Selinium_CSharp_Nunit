using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSelenium.NUnitTest
{
    [Allure.NUnit.AllureNUnit]
    internal class CalculatorUnitTesting
    {
        Calculator cl = new Calculator();

        [Test]
        public void TestAdd()
        {
            int res = cl.Add(2, 3);

            int res1 = cl.Add(3, -4);

            //Assertion
            //Assert.AreEqual(5, res);
            //Assert.AreEqual(-1, res1);
        }

        [Test]
        public void TestSub()
        {
            int res = cl.Sub(5, 3);

            int res1 = cl.Sub(3, -4);

            //Assertion
            //Assert.AreEqual(2, res);
            //Assert.AreEqual(7, res1);
        }
        [Test]
        public void TestMul()
        {
            int res = cl.Mul(5, 3);

            int res1 = cl.Mul(3, -4);

            //Assertion
            //Assert.AreEqual(15, res);
            //Assert.AreEqual(-12, res1);
        }

        [Test]
        public void TestDiv()
        {
            int res = cl.Div(5, 5);

            int res1 = cl.Div(30, 10);

            //Assertion
            //Assert.AreEqual(1, res);
            //Assert.AreEqual(3, res1);
        }
    }
}
