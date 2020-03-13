using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        ThreadStart ts1 = new ThreadStart(PrintZero);
        Thread t1 = new Thread(ts1);
        ThreadStart ts2 = new ThreadStart(PrintOne);
        Thread t2 = new Thread(ts2);
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