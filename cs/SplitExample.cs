using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string: ");
        string str = Console.ReadLine();
        string[] condition = { "," };
        string[] result = str.Split(condition, StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine("Number of comma is: " + (result.Length - 1));
    }
}