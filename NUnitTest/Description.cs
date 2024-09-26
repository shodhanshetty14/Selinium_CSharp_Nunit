using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSelenium.NUnitTest
{
    
        [Allure.NUnit.AllureNUnit]
    internal class Description
    {
        [Test, Description("used to show how the description works")]
        public void testcase()
        {
            Console.WriteLine("The first test case");
        }
    }
}
