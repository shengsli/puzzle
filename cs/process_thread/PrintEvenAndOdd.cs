using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        ThreadStart ts1 = new ThreadStart(PrintEven);
        Thread t1 = new Thread(ts1);
        ThreadStart ts2 = new ThreadStart(PrintOdd);
        Thread t2 = new Thread(ts2);
        t1.Start();
        t2.Start();
    }

    private static void PrintEven()
    {
        for(int i = 0; i <= 10; i=i+2)
        {
            Console.WriteLine(i);
        }
    }

    public static void PrintOdd()
    {
        for(int i = 1; i <= 10; i = i + 2)
        {
            Console.WriteLine(i);
        }
    }
}