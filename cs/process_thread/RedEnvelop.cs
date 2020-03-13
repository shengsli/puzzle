using System;
using System.Threading;

namespace Application
{
    class Program
    {
        private static int count = 10;
        private static void SendRedEnvelop()
        {
            while (count > 0)
            {
                // send red envelop
                count--;
                Console.WriteLine($"remains {count} red envelops.");
                if (count == 5)
                {
                    Console.WriteLine("stop sending red envelops.");
                    Thread.CurrentThread.Abort();
                }
            }
        }
        static void Main(string[] args)
        {
            ThreadStart ts = new ThreadStart(SendRedEnvelop);
            Thread t = new Thread(ts);
            t.Start();
        }
    }
}