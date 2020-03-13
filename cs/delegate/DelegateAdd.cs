using System;

namespace DelegateAddApplication
{
    public class CalculationProgram
    {
        public delegate int PerformCalculation(int x, int y);
        public static int Add(int x, int y)
        {
            return x + y;
        }
        
        static void Main(string[] args)
        {
            PerformCalculation handler = Add;
            Console.WriteLine(handler(1, 2));
        }
    }
}
