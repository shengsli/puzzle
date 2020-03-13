using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        //在D盘下创建code文件夹
        Directory.CreateDirectory("D:\\code");
        FileInfo fileInfo = new FileInfo("D:\\code\\test1.txt");
        if (!fileInfo.Exists)
        {
            //创建文件
            fileInfo.Create().Close();
        }
        fileInfo.Attributes = FileAttributes.Normal;//设置文件属性
        Console.WriteLine("file path: "+ fileInfo.Directory);
        Console.WriteLine("file name: "+ fileInfo.Name);
        Console.WriteLine("isReadOnly: "+ fileInfo.IsReadOnly);
        Console.WriteLine("file size: " +fileInfo.Length);
        //先创建code-1 文件夹
        //将文件移动到code-1文件夹下
        Directory.CreateDirectory("D:\\code-1");
        //判断目标文件夹中是否含有文件test1.txt
        FileInfo newFileInfo = new FileInfo("D:\\code-1\\test1.txt");
        if (!newFileInfo.Exists)
        {
            //移动文件到指定路径
            fileInfo.MoveTo("D:\\code-1\\test1.txt");
        }
    }
}