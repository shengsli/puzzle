using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a path");
        string path = Console.ReadLine();
        Console.WriteLine("file name without extension: " + Path.GetFileNameWithoutExtension(path));
        Console.WriteLine("extension: " + Path.GetExtension(path));
        Console.WriteLine("file name: " + Path.GetFileName(path));
        Console.WriteLine("directory: " + Path.GetDirectoryName(path));
        //更改文件扩展名
        string newPath = Path.ChangeExtension(path, "doc");
        Console.WriteLine("changed file name: " + Path.GetFileName(newPath));
    }
}