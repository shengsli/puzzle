// create dir if not exist 
// delete dir if exist

using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        bool flag = Directory.Exists("D:\\code");
        Console.WriteLine(flag);
        if (flag)
        {
            Directory.Delete("D:\\code", true);
        }
        else
        {
            Directory.CreateDirectory("D:\\code");
        }
    }
}