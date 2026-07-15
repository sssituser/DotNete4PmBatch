using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Class6
    {
        static void Main(string[] args)
        {
            int[] array = { 56, 78, 34, 89, 23, 45 };

            Console.WriteLine("Array elemnents before sorting");
            foreach(int i in array)
            {
                Console.Write($"{i}   ");
            }
            // sorting technique
            for(int i = 0; i < array.Length; i++)
            {
                for(int j=i+1;j<array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int copy = array[i];
                        array[i] = array[j];
                        array[j] = copy;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Array elemnents after sorting");
            foreach (int i in array)
            {
                Console.Write($"{i}   ");
            }
        }
    }
}
