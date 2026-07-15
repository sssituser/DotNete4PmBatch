using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Class13
    {
        static void Main(string[] args)
        {
            int[] array = { 34, 56, 78, 90, 12, 34, 56, 78, 90, 78, 89, 56, 34 };

            var res = array.GroupBy(x => x).ToDictionary(x=>x.Key,x=>x.Count());
            //foreach(var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            foreach (KeyValuePair<int, int> keyValuePair in res)
            {
                Console.WriteLine(keyValuePair);
            }
        }
    }
}
