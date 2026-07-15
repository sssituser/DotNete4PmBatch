using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    internal class Class9
    {
        static void Main(string[] args)
        {
            Console.Write("Enter num : ");
            int num = int.Parse(Console.ReadLine()); // num = 9, 100,-1,0
            if (num > 0)
            {
                if (num < 10)
                {
                    Console.WriteLine("Entered number is +ve and singe digit");
                }
                else
                {
                    Console.WriteLine("Entered number is +ve , but not a single digit");
                }
            }
            else
            {
                Console.WriteLine("Entered number is not a +ve num");
            }
        }
    }
}
