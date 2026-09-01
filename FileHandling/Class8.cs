using System;
using System.IO;

namespace FileHandling
{
    internal class Class8
    {
        static void Main(string[] args)
        {


      
            foreach(DriveInfo drInfo in DriveInfo.GetDrives())
            {
                long totalSpaceSize = drInfo.TotalSize / (1024*1024*1024);
                long freeSpaceSize = drInfo.TotalFreeSpace / (1024*1024*1024);
                long useSpaceSize = totalSpaceSize - freeSpaceSize;
                Console.WriteLine($"========================================================================================================");
                Console.WriteLine($"{drInfo.Name.Substring(0,drInfo.Name.Length-2)} Drive\t\tTotal Space : {totalSpaceSize} GB\t\tUsed Space : {useSpaceSize} GB\t\tFree Space : {freeSpaceSize} GB");
                Console.WriteLine($"===========================Folders Present In the {drInfo.Name.Substring(0,drInfo.Name.Length-2)} Drive================================================");
                DirectoryInfo info = new DirectoryInfo(drInfo.Name);
                foreach(DirectoryInfo dinfo in info.GetDirectories())
                {
                    Console.WriteLine(dinfo.Name);
                }
              

                Console.WriteLine($"===========================Files Present In the {drInfo.Name.Substring(0, drInfo.Name.Length - 2)} Drive================================================");
             
                foreach (FileInfo finfo in info.GetFiles())
                {
                    Console.WriteLine(finfo.Name);
                }
                Console.WriteLine($"========================================================================================================");


            }
        }
    }
}
