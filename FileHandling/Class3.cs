using System;
using System.IO;

namespace FileHandling
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            Console.WriteLine("The Drives Present in the Laptop");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("DriveName\tTotalSp\tUsedSp\tAvailableSp");
            Console.WriteLine("-----------------------------------------------------------");
            foreach (var drive in drives)
            {

                long dgb = drive.TotalSize / (1024 * 1024 * 1024);
                long afgb = drive.AvailableFreeSpace / (1024 * 1024 * 1024);
                Console.WriteLine($"{drive.Name}\t\t{dgb}GB\t{dgb - afgb}GB\t{afgb}GB");

                string res = Directory.GetDirectoryRoot(drive.Name);
                string[] dires = Directory.GetDirectories(res);
                Console.WriteLine("============================");
                Console.WriteLine($"Folders in the {res.Substring(0, res.Length - 2)} Drive");
                Console.WriteLine("============================");
                foreach (var item in dires)
                {
                    Console.WriteLine(item);
                }


            }
            Console.WriteLine("-----------------------------------------------------------");
        }
    }


}
// 1 Byte = 8bits
// 1024bytes =1kb
// 1024kbs = 1MB
// 1024MB = 1GB
// 1024GBS = 1TB