using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    internal class Class7
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");// 0
            int num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine($"{num} is +ve");
            }
            else
            {
                Console.WriteLine("num is zero or -ve");
            }
        }
    }
}
