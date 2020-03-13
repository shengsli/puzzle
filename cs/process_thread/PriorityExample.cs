using System;
using System.Threading;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadStart ts1 = new ThreadStart(PrintZero);
            Thread t1 = new Thread(ts1);
            t1.Priority = ThreadPriority.Lowest;
            ThreadStart ts2 = new ThreadStart(PrintOne);
            Thread t2 = new Thread(ts2);
            t2.Priority = ThreadPriority.Highest;
            t1.Start();
            t2.Start();
        }

        private static void PrintZero()
        {
            for (int i = 0; i < 100; i++)
                Console.WriteLine(0);
        }

        public static void PrintOne()
        {
            for (int i = 0; i < 100; i++)
                Console.WriteLine(1);
        }
    }
}