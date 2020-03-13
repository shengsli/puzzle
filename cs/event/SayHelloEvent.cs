using System;

class Program
{
    public delegate void SayHelloDelegate();
    public event SayHelloDelegate SayHelloEvent;
    public void SayHello()
    {
        Console.WriteLine("Hello Event！");
    }
    public void SayHelloEventTrigger()
    {
        SayHelloEvent();
    }
    static void Main(string[] args)
    {
        Program program = new Program();
        program.SayHelloEvent = new SayHelloDelegate(program.SayHello);
        program.SayHelloEventTrigger();
    }
}