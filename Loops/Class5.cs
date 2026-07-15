using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    // num = 5
    // 5 x 1 = 5
    // 5 x 2 = 10

    // 5 x 10 = 50
    internal class Class5
    {
        static void Main(string[] args)
        {
            int start = 1;
            int end = 10;
            int num = 5;
            while( start <= end)
            {
                Console.WriteLine($"{num} x {start} = {start*num} ");
                start++;
            }
        }
    }
}
