using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSelenium.NUnitTest
{

    [SetUpFixture]
    internal class BaseClass
    {
        [OneTimeSetUp]
        public void dbConnectionOpen()
        {
            TestContext.Progress.WriteLine("The DB connection is OPen now");
        }

        [OneTimeTearDown]
        public void dbConnectionClose()
        {
            TestContext.Progress.WriteLine("DB connection close");
        }
    }
}
