using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Console.Write("Enter File Name : ");
            string finame = Console.ReadLine();
            FileInfo finfo = new FileInfo(finame);
            if (finfo.Exists)
            {
                Console.WriteLine($"This FileName Already Exists");
            }
            else
            {
                finfo.Create();
                Console.WriteLine("File Created");
            }
        }
    }
}
