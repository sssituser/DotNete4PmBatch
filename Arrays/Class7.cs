using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Class7
    {
        static void Main(string[] args)
        {
            int[] array = { 56, 78, 34, 89, 23, 45 };
            Console.WriteLine($"Max Element in the Array : {array.Max()}");
            Console.WriteLine($"Min Element in the Array : {array.Min()}");
            Console.WriteLine($"sum of the array Element in the Array : {array.Sum()}");

        }
    }
}
