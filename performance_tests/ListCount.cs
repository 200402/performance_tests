using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace performance_tests
{
     class ListCount : ITest
    {
        List<int> number = new();

        public string descriptionTest1() { return "Постоянный Count"; }
        public void Test1()
        {
            for (int i = 0; i < number.Count; i++)
            {
                number[i] -= 1;
            }
        }

        public string descriptionTest2() { return "a = Count"; }
        public void Test2()
        {
            var a = number.Count;
            for (int i = 0; i < a; i++)
            {
                number[i] -= 1;
            }
        }


        public ListCount()
        {
            for (int i = 0; i < 214748364; i++)
            {
                number.Add(i);
            }
        }
    }
}
