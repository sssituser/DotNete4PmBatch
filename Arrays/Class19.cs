using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Class19
    {
        static void Main(string[] args)
        {
            int[][] a = new int[3][];
            a[0] = new int[] { 1, 2, 3 };
            a[1] = new int[] { 4,5,6,7,8,9};
            a[2] = new int[] { 10,11,12,13 };
            
            for(int i = 0; i < a.Length; i++)
            {
                foreach(int k in a[i])
                {
                    Console.Write($"{k}\t");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
