using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    /* Write a program to find the factorial of a number
     * num = 5  res = 1*2*3*4*5  res = 120
     */
    internal class Class7
    {
        static void Main(string[] args)
        {
            int start = 1;
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine());
            int fact = 1;
            while (start <= num)
            {
                fact = fact * start;
                start += 1;
            }
            Console.WriteLine($"{num}! is {fact}.");
        }
    }
}
