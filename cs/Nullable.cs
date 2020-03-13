using System;
class Program
{
    static void Main(string[] args)
    {
        int? i = null;
        double? d = 3.14;
        Nullable<int> a = null;
        
        if (i.HasValue)
            Console.WriteLine("i = {0}", i);
        else
            Console.WriteLine("i is null. ");

        if (d.HasValue)
            Console.WriteLine("d = {0}", d);
        else
            Console.WriteLine("d is null. ");

        if (a.HasValue)
            Console.WriteLine("a = {0}", a);
        else
            Console.WriteLine("a is null. ");
    }  
}