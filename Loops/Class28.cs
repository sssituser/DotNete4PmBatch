using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    /*
     * 1
     * 1    2
     * 1    2   3
     * 1    2   3   4
     * 1    2   3   4   5
     * 1    2   3   4
     * 1    2   3
     * 1    2
     * 1
     */
    internal class Class28
    {
        static void Main(string[] args)
        {
            int num = 5, k = 65;
            for(int i = 1; i <= num; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write($"{(char)k++}\t");
                }
                Console.WriteLine();
            }

            for(int i = num - 1; i >= 1; i--)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write($"{(char)k++}\t");
                }
                Console.WriteLine();
            }
            
        }
    }
}
