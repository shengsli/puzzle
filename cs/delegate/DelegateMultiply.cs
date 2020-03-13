using System;

namespace DelegateMultiplyApplication
{
    class Program
    {
        public delegate int MultiplyDelegate(int x, int y);

        public static int Multiply(int x, int y)
        {
            return x*y;
        }

        static void Main(string[] args)
        {
            MultiplyDelegate d = Multiply;
            Console.WriteLine(d(1,2));
        }
    }
}