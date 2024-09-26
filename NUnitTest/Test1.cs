using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSelenium.NUnitTest
{
    [Allure.NUnit.AllureNUnit]
    internal class Test1
    {

        [Test]
        public void testcase1()
        {
            Console.WriteLine("This is the first test case");
        }
    }
}
