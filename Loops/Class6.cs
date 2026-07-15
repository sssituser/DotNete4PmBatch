using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    /*
     * Write program to find the sum of n numbers for the given number.
     * num = 5   sum = 1+2+3+4+5 = Sum= 15
     */
    internal class Class6
    {
        static void Main(string[] args)
        {
            int start = 1;
            int num = 5;
            int sum = 0;
            while (start <= num)
            {
              
                sum += start;
                start += 1;
            }
            Console.WriteLine($"Sum of {num} number is : {sum}");
        }
    }
}
