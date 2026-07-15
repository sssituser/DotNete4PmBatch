using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Class11
    {
        static void Main(string[] args)
        {
            int[] array = { 12, 11, 23, 45, 11, 56, 45, 77, 78, 77, 90, 78, 67 };
            Console.WriteLine("====Elements in the array==============");
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("=================Duplicate Elements in the array======");
            var dups = array
                .GroupBy(x => x)
                .Where(y => y.Count() > 1)
                .Select(g => g.Key)
                .ToList();

            foreach (int k in dups)
            {
                Console.WriteLine(k);
            }
            Console.WriteLine("=================Uniques Elements in the array======");
            var uniques = array
                .GroupBy(x => x)
                .Where(y => y.Count() == 1)
                .Select(g => g.Key)
                .ToList();
            foreach (int k in uniques)
            {
                Console.WriteLine(k);
            }
        }
    }
}
