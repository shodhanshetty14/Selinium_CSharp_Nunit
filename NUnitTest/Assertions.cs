using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Constraints;

namespace NUnitSelenium.NUnitTest
{
    [Allure.NUnit.AllureNUnit]
    internal class Assertions
    {
        [Test]
        public void AssertionTest()
        {

            string actual = "google";
            string expected = "google";

            //Assert.AreEqual(actual, expected);
            Assert.That(actual, Is.EqualTo(expected));
            Assert.That(actual, Is.Not.EqualTo(expected));

            //Assert for string IgnoreCase
            Assert.That(actual, Is.EqualTo(expected).IgnoreCase);

            //Substring present
            Assert.That(actual, Does.Contain("llo").IgnoreCase);
            Assert.That(actual, Does.Not.Contain("hu").IgnoreCase);

            //Empty Assertions
            Assert.That(actual, Is.Empty);
            //Assert.IsNull(actual);
            //Assert.IsNotNull(actual);

            //Collection COnstraints
            int[] arr = new int[] {1, 2, 3, 4, 5, 6};
            //Assert.NotNull(arr);
            Assert.That(actual, Is.All.GreaterThan(0));
            Assert.That(actual, Is.Empty);
            Assert.That(actual, Is.Not.Empty);

            //Custom Assertion
            int age = 17;
            if(age<18)
                {
                throw new AssertionException("age is less than 18");
            }



       /* if(actual == expected)
            {
                Console.WriteLine("Results match");
            }
            else
            {
                Console.WriteLine("Results does not match");
            }*/
        }
    }
}
