using System;
using System.Threading;

namespace Application
{
    class Program
    {
        public void PrintEven()
        {
            lock (this)
            {
                for (int i = 0; i <= 10; i = i + 2)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + "--" + i);
                }
            }
        }

        public void PrintOdd()
        {
            lock (this)
            {
                for (int i = 1; i <= 10; i = i + 2)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + "--" + i);
                }
            }
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            ThreadStart ts1 = new ThreadStart(program.PrintOdd);
            Thread t1 = new Thread(ts1);
            t1.Name = "t1";
            t1.Start();
            ThreadStart ts2 = new ThreadStart(program.PrintEven);
            Thread t2 = new Thread(ts2);
            t2.Name = "t2";
            t2.Start();
        }
    }
}