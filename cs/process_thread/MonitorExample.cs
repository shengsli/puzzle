using System;
using System.Threading;

namespace Application
{
    class Program
    {
        public void PrintOnes()
        {
            Monitor.Enter(this);
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + ": 1");
                }
            }
            finally
            {
                Monitor.Exit(this);
            }
        }
        public void PrintZeros()
        {
            Monitor.Enter(this);
            try
            {
                for (int i = 1; i < 10; i++)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + ": 0");
                }
            }
            finally
            {
                Monitor.Exit(this);
            }
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            ThreadStart ts1 = new ThreadStart(program.PrintOnes);
            Thread t1 = new Thread(ts1);
            t1.Name = "print ones";
            t1.Start();
            ThreadStart ts2 = new ThreadStart(program.PrintZeros);
            Thread t2 = new Thread(ts2);
            t2.Name = "print zeros";
            t2.Start();
        }
    }
}