// executable must run in d:
// directories are created when exe run in d:

using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        DirectoryInfo directoryInfo = new DirectoryInfo("D:\\code");
        directoryInfo.Create();
        directoryInfo.CreateSubdirectory("code-1");
        directoryInfo.CreateSubdirectory("code-2");

        IEnumerable<DirectoryInfo> dir = directoryInfo.EnumerateDirectories();
        foreach (var v in dir)
        {
            Console.WriteLine(v.Name);
        }

        // directoryInfo.Delete(true);
    }
}