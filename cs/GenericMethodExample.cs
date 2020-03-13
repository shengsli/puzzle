using System;

class MyTest<T>
{
    private T[] items = new T[3];
    private int index = 0;
    
    //向数组中添加项
    public void Add(T t)
    {
        if (index < 3)
        {
            items[index] = t;
            index++;
        }
        else
        {
            Console.WriteLine("array is full. ");
        }
    }

    //读取数组中的全部项
    public void Show()
    {
        foreach (T t in items)
        {
            Console.WriteLine(t);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyTest<int> test = new MyTest<int>();
        test.Add(10);
        test.Add(20);
        test.Add(30);
        test.Show();
    }
}