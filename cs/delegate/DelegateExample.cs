using System;

namespace App
{
    class HelloClass
    {
        public static void SayHello()
        {
            Console.WriteLine("Hello delegate.");
        }
    }

    class Program
    {
        public delegate void SayHelloDelegate();
        static void Main(string[] args)
        {
            SayHelloDelegate d = new SayHelloDelegate(HelloClass.SayHello);
            d();
        }
    }
}