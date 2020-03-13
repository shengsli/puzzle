using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("employee: ");
        string name = Console.ReadLine();
        Console.Write("company: ");
        string company = Console.ReadLine();
        Console.WriteLine("{0} works for {1}. ", name, company);
    }
}