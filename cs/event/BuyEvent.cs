using System;

class Program
{
    static void Main(string[] args)
    {
        MyEvent myEvent = new MyEvent();
        myEvent.BuyEvent += new MyEvent.BuyDelegate(MyEvent.BuyFood);
        myEvent.BuyEvent += new MyEvent.BuyDelegate(MyEvent.BuyCake);
        myEvent.BuyEvent += new MyEvent.BuyDelegate(MyEvent.BuyFlower);
        myEvent.BuyEventTrigger();
    }
}
class MyEvent
{
    public delegate void BuyDelegate();
    public event BuyDelegate BuyEvent;
    public static void BuyFood()
    {
        Console.WriteLine("buy fast food");
    }
    public static void BuyCake()
    {
        Console.WriteLine("buy cake");
    }
    public static void BuyFlower()
    {
        Console.WriteLine("buy flowers");
    }
    public void BuyEventTrigger()
    {
        BuyEvent();
    }
}