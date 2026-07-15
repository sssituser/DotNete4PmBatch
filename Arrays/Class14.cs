using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Class14
    {
        //1 Model of Initilization
        static void Main(string[] args)
        {
            int[,] a = new int[2, 3];
            a[0, 0] = 12;
            a[0, 1] = 13;
            a[0, 2] = 41;
            a[1, 0] = 55;
            a[1, 1] = 49;
            a[1, 2] = 60;
            Console.WriteLine(a[0, 0]);
            Console.WriteLine(a[0, 1]);
            Console.WriteLine(a[0, 2]);
            Console.WriteLine(a[1, 0]);
            Console.WriteLine(a[1, 1]);
            Console.WriteLine(a[1, 2]);
        }
    }
}
