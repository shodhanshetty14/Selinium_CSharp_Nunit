using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSelenium.TestDrivenTesting
{
    internal class TestParUsingTestCase
    {

        
        [TestCase("abc.com", "ghhff")]
        [TestCase("xyz.com", "gfyhjbn")]
        [TestCase("dhj.com", "gvhb")]


        public void LoginTest(string username, string password)
        {
            Console.WriteLine(username + "-" +  password);
        }
    }
}
