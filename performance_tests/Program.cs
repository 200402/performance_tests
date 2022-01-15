using System;
using System.Diagnostics;

namespace performance_tests
{
    class Program
    {
        static void Main(string[] args)
        {
            var testClass = new ListCount();
            Console.WriteLine(testClass.descriptionTest1());
            for (int i = 0; i < 10; i++)
            {
                test(testClass.Test1);
            }
            Console.WriteLine();
            Console.WriteLine(testClass.descriptionTest2());
            for (int i = 0; i < 10; i++)
            {
                test(testClass.Test2);
            }
        }
        static void test(Action method)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            method();
            stopWatch.Stop();
            TimeWrite(stopWatch.Elapsed);
        }

        static void TimeWrite(TimeSpan ts)
        {
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine(elapsedTime);
        }
    }
}
