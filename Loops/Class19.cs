using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Class19
    {

        static void Main(string[] args)
        {
            int num = 5;

            for(int start = 1; start <= num; start++)
            {
                Console.WriteLine($"starat = {start}");
                for(int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{start} x {i}  = {start*i}");
                }
            }
        }
    }
}
