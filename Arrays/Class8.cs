using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    /*foraeach(datatype var1 in var2){ // Group of elments
     * 
     * }
     */
    internal class Class8
    {
        static void Main(string[] args)
        {
            int[] array = { 56, 78, 34, 89, 23, 45 };

            Console.WriteLine("===========================Elements before sorting========");
            foreach(int i in array)
            {
                Console.Write($"{i}\t");
            }
            Console.WriteLine();
            var res = array.OrderBy(x=>x);
            Console.WriteLine("==================Array Elements After sorting======");
            foreach(int val in res)
            {
                Console.Write($"{val}\t");
            }

        }
    }
}
