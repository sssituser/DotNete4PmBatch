using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Class11
    {
        static void Main(string[] args)
        {
            int num = 456;
            int count = 0;
            int sum = 0;
            while (num != 0)
            {
                int digit = num % 10;
                sum += digit;
                count++;
                num /= 10;
            }
            Console.WriteLine($"Average of the digits is : {sum/count}");
        }
    }
}
