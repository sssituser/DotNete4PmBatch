using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a File Name To Delete : ");
            FileInfo finfo = new FileInfo(Console.ReadLine());
            if (finfo.Exists)
            {
                finfo.Delete();
                Console.WriteLine("File Deleted Successfully.");
            }
            else
            {
                Console.WriteLine("File Not Found..");
            }
        }
    }
}
