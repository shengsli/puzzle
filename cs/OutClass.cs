using System;

class OutClass
{
    public void Judge(int num, out bool result)
    {
        if (num % 5 == 0)
        {
            result = true;
        }
        else
        {
            result = false;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        OutClass outClass = new OutClass();
        bool rs;
        outClass.Judge(20, out rs);
        Console.WriteLine(rs);
    }
}
