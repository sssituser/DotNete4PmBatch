using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Class12
    {
        static void Main(string[] args)
        {
            int[] array = { 34, 56, 78, 90, 12, 34, 56, 78, 90, 78, 89, 56, 34 };

            //var res = array.Distinct().ToDictionary(x => x, x => x * x);
            //foreach(var x in res)
            //{
            //    Console.WriteLine($"{x.Key}  ; {x.Value}");
            //}

           

            var dict = array
                .GroupBy(x => x)
                .ToDictionary(g => g.Key, g => g.Count());

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }


        }
    }
}
