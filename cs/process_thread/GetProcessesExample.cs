using System;
using System.Diagnostics;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Process[] processes = Process.GetProcesses();
            foreach (Process p in processes)
            {
                Console.WriteLine(p.ProcessName);
            }
        }
    }
}