using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    // sum of the digits of a give number
    // num = 123  sum = 6
    internal class Class10
    {
        static void Main(string[] args)
        {
            int num = 456;
            int sum = 0;
            while (num != 0)
            {
                int digit = num % 10;
                sum +=  digit;
                num /= 10;
            }
            Console.WriteLine($"Sum of the digits of a given number : {sum}");
        }
    }
}
