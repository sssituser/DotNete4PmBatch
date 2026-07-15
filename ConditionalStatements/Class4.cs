using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    internal class Class4
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine());

            if (num == 0)
            {
                Console.WriteLine("ZERO");
            }
            if (num == 1)
            {
                Console.WriteLine("ONE");
            }
            if (num == 2) 
            {
                Console.WriteLine("TWO");
            }
            if (num == 3)
            {
                Console.WriteLine("THREE");
            }
        }
    }
}
