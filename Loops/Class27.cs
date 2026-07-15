using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Class27
    {
        static void Main(string[] args)
        {
            int num = 5;
            int k = 97;
            for (int row = 1; row <= num; row++)
            {

                for (int j = 1; j <= row; j++)
                {
                    Console.Write($"{(char)k++}\t");
                }
                Console.WriteLine();

            }
        }
    }
}
