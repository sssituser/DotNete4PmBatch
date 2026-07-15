using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Class9
    {
        static void Main(string[] args)
        {

            int[] array = { 56, 78, 34, 89, 23, 45 };
            Console.WriteLine("==============Elements Before sorting============");
            foreach(int k in array)
            {
                Console.Write($"{k}\t");
            }
            Console.WriteLine("\n==============Elements After sorting============");
            var res = array.OrderByDescending(x => x);
            foreach (int k in res)
            {
                Console.Write($"{k}\t");
            }
        }
    }
}
