using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Class22
    {
        static void Main(string[] args)
        {
            int num = 5;
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} x {i} = {num*i}");
            }

        }
    }
}
/*
 *  5 x 1 = 5
 *  .......
 *  5 x 10 = 50
 */