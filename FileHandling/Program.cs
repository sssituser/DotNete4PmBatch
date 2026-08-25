using System;
using System.IO;
namespace FileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Folder Name : ");
            string foname =Console.ReadLine();
            DirectoryInfo dinfo=new DirectoryInfo(foname);
            if (dinfo.Exists)
            {
                Console.WriteLine($"{foname} Exists already try with anoter name");
            }
            else
            {
                dinfo.Create();
                Console.WriteLine("Your Folder Created Successfully.....");
            }

            
        }
    }
}
