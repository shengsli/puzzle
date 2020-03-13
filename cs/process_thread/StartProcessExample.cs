using System;
using System.Diagnostics;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Process p = new Process();
            p.StartInfo.FileName = "mspaint";
            p.Start();
        }
    }
}