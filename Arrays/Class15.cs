using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Class15
    {
        static void Main(string[] args)
        {
            int[,] a = new int[2, 3] { {12,34,56 }, {77,88,99 } };
            foreach (int element in a)
            {
                Console.WriteLine(element);
            }
        }
    }
}
