using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Class9
    {
       
        static void Main(string[] args)
        {
            int num = 1234567;
            int count = 0;
            while (num != 0) // 456 !=0 - T 45! = 0 - T 4!=0-T 0!=0-F
            {
                int digit = num % 10; // digit = 456%10 - >6 digit = 45%10 digit = 5 digit = 4%10 digit = 4
                count++; // count = 1 count = 2 count = 3
                num = num / 10; // num = 456/10 num = 45/10 num = 4/10 num = 0
            }
            Console.WriteLine($"Digits Count : {count}");
        }
    }
}
