using System;
using System.Threading;
class Program
{
    static void Main(string[] args)
    {
        ParameterizedThreadStart pts = new ParameterizedThreadStart(PrintEven);
        Thread t = new Thread(pts);
        t.Start(10);
    }
    private static void PrintEven(Object n)
    {
        for (int i = 0; i <= (int)n; i = i + 2)
        {
            Console.WriteLine(i);
        }
    }
}