using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Class3
    {
        // 10
        // 1 4 9 16 25 36 49 64  81 100
        static void Main(string[] args)
        {
            int start = 1;
            int end = 10;
            while (start <= end)
            {
                Console.WriteLine(start*start);
                start++;
            }
        }
    }
}
