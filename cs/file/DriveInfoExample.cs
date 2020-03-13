using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        DriveInfo driveInfo = new DriveInfo("C");
        Console.WriteLine("drive name: " + driveInfo.Name);
        Console.WriteLine("drive type: " + driveInfo.DriveType);
        Console.WriteLine("drive format: " + driveInfo.DriveFormat);
        Console.WriteLine("total free space: " + driveInfo.TotalFreeSpace / 1024 / 1024);
        Console.WriteLine("total size: " + driveInfo.TotalSize);

        DriveInfo[] driveInfos = DriveInfo.GetDrives();
        foreach (DriveInfo d in driveInfos)
        {
            if (d.IsReady)
            {
                Console.WriteLine("drive name: " + d.Name);
                Console.WriteLine("drive format: " + d.DriveFormat);
            }
        }
    }
}