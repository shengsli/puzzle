using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        ParameterizedThreadStart pts = new ParameterizedThreadStart(PrintEven);
        ParameterTest pt = new ParameterTest(1, 10);
        Thread t = new Thread(pts);
        t.Start(pt);
    }
    private static void PrintEven(Object n)
    {
        if (n is ParameterTest)
        {
            int beginNum = ((ParameterTest)n).beginNum;
            int endNum = ((ParameterTest)n).endNum;
            for (int i = beginNum; i <= endNum; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
public class ParameterTest
{
    public int beginNum;
    public int endNum;
    public ParameterTest(int a, int b)
    {
        this.beginNum = a;
        this.endNum = b;
    }
}