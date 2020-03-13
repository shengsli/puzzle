using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        ThreadStart ts = new ThreadStart(PrintEven);
        Thread t = new Thread(ts);
        t.Start();
    }
    private static void PrintEven()
    {
        for(int i = 0; i <= 10; i=i+2)
        {
            Console.WriteLine(i);
        }
    }
}