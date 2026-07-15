using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Class10
    {
        static void Main(string[] args)
        {
            int[] array = { 11, 22, 45, 67, 44, 68, 90, 67, 34 };

            Console.WriteLine("==========Array elements are ==================");
            foreach(int k in array)
            {
                Console.WriteLine(k);
            }
            var evens = array.Where(x => x % 2 == 0);
            Console.WriteLine("==========Even elements are ==================");
            foreach (int k in evens)
            {
                Console.WriteLine(k);
            }
            var odds = array.Where(x => x % 2 != 0);
            Console.WriteLine("==========odd elements are ==================");
            foreach (int k in odds)
            {
                Console.WriteLine(k);
            }
        }
    }
}
