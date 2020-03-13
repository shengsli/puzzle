using System;
class Program
{
    static void Main(string[] args)
    {
        Random rd = new Random();
        Console.WriteLine("generate a no. btw 0 and 10: {0}", rd.Next(0, 10));
        Console.WriteLine("generate a float btw 0 and 1: {0}", rd.NextDouble());
        byte[] b = new byte[5];
        rd.NextBytes(b);
        Console.Write("generate a byte: ");
        foreach(byte i in b)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}