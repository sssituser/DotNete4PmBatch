using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Class8
    {
        // Separate the digits of a given number ?
        // num = 456  res = 6  5  4
        static void Main(string[] args)
        {
            int num = 456;
            while (num != 0) // 456!=0 T 45!=0-T 4!=0-T 0!=0 F
            {
                int digit = num % 10; // di = 456%10 di =6 di= 45%10 di = 5 di = 4%10 di = 4
                 Console.WriteLine(digit); //6 5 4
                num = num / 10; // num = 456/10 num = 45/10 num = 4/10 num = 0
            }
        }
    }
}
