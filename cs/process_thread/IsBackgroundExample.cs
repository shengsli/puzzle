using System;
using System.Threading;

namespace Application
{
    class Program
    {
        private static void PrintZero()
        {
            for (int i = 0; i < 100; i++)
                Console.WriteLine(0);
        }
        static void Main(string[] args)
        {
            ThreadStart ts = new ThreadStart(PrintZero);
            Thread t = new Thread(ts);
            t.Start();
            if (t.IsBackground == false)
            {
                Console.WriteLine("This thread is not background thread.");
                t.IsBackground = true;
            }
            else
            {
                Console.WriteLine("This thread is background thread.");
            }
        }
    }
}