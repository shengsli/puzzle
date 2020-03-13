using System;

public class Program
{
    static void Main(string[] args)
    {
        DateTime dt = DateTime.Now;
        Console.WriteLine(dt);
        Console.WriteLine(dt.Date);
        Console.WriteLine(dt.Day);
        Console.WriteLine(dt.AddHours(1f));

        DateTime dt1 = DateTime.Now;
        DateTime dt2 = new DateTime(2020, 1, 5);
        TimeSpan ts = dt2 - dt1;
        Console.WriteLine(ts.Days);
    }
}