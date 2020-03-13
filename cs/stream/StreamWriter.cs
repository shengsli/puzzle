using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string path = @"D:\\code\\test.txt";
        //创建StreamWriter 类的实例
        StreamWriter streamWriter = new StreamWriter(path);
        //向文件中写入姓名
        streamWriter.WriteLine("zhang");
        //向文件中写入手机号
        streamWriter.WriteLine("13112345678");
        //刷新缓存
        streamWriter.Flush();
        //关闭流
        streamWriter.Close();
    }
}