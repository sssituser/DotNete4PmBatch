using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 10;
            if (num1 > num2) // 10>10-F
            {
                Console.WriteLine("num1 is max");

            }
            if (num2 > num1) //10>10 - F
            {
                Console.WriteLine("num2 is max");
            }
            if (num1 == num2) // 10==10 -T
            {
                Console.WriteLine("num1 and num2 are equal");
            }
        }
    }
}
