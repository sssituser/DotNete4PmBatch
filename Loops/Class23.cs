using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Class23
    {
        static void Main(string[] args)
        {
            int num = 5;
            for(int i = 1; i <= num; i++)
            {
                Console.WriteLine($"===============i = {i} ==========");
                for(int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} x {j}  = {i*j}");
                }

            }
        }
    }
}
