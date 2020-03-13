using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter 1st num: ");
        double num1 = Double.Parse(Console.ReadLine());
        Console.WriteLine("enter 2nd number: ");
        double num2 = Double.Parse(Console.ReadLine());
        Console.WriteLine("the larger one is {0}", Math.Max(num1, num2));
        Console.WriteLine("the smaller one is {0}", Math.Min(num1, num2));
    }
}