using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSelenium.NUnitTest
{
    internal class Factorial
    {
        public int FactorialNum(int n)
        {
            if (n == 0)
                return 1;
            return n * FactorialNum(n - 1);
        }
    }
}
