using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace performance_tests
{
    interface ITest
    {
        string descriptionTest1 () { return ""; }
        void Test1();

        string descriptionTest2() { return ""; }
        void Test2();
    }
}
