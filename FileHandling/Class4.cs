using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    internal class Class4
    {
        static void Main(string[] args)
        {
            Console.Write("Enter File Name : ");
            string fname = Console.ReadLine();
            StreamWriter sw = new StreamWriter(fname,true);
            Console.WriteLine("=====Enter Your Information========");
            string info = string.Empty;
            while(!string.IsNullOrEmpty(info=Console.ReadLine()))
            {
                sw.WriteLine(info);
            }
         
            sw.Close();
        }
    }
}
