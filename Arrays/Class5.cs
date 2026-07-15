using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Class5
    {
        static void Main(string[] args)
        {
            int[] array = { 56, 78, 34, 89, 23, 45 };
            Console.WriteLine($"Elements count in the array : {array.Length}");

            for (int i = 0; i < array.Length; i++) // i = 0;0<6-T ; 1<6-T
            {
                Console.WriteLine(array[i]);//56 78
            }


        }
    }
}
