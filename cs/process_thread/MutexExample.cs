using System;
using System.Threading;

class Program
{
    private static Mutex mutex = new Mutex();
    public static void PrintOnes()
    {
        if (mutex.WaitOne())
        {
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + ": 1");
                }
            }
            finally
            {
                Console.WriteLine("finish printing ones.");
                mutex.ReleaseMutex();
            }
        }
    }

    public static void PrintZeros()
    {
        if (mutex.WaitOne())
        {
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + ": 0");
                }
            }
            finally
            {
                Console.WriteLine("finish printing zeros.");
                mutex.ReleaseMutex();
            }
        }
    }

    public static void Park(object num)
    {
        if (mutex.WaitOne())
        {
            try
            {
                Console.WriteLine("car {0} in", num);
                Thread.Sleep(1000);
            }
            finally
            {
                Console.WriteLine("car {0} out", num);
                mutex.ReleaseMutex();
            }
        }
    }

    static void Main(string[] args)
    {
        ParameterizedThreadStart ts = new ParameterizedThreadStart(Park);
        Thread t1 = new Thread(ts);
        t1.Start("A10000");
        Thread t2 = new Thread(ts);
        t2.Start("A20000");
    }
}