using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    // num = 10
    //10 9 8 7 6 5 4 3 2 1
    internal class Class4
    {
        static void Main(string[] args)
        {
            int start = 10;
            int end = 1;

            while(start >= end)
            {
                Console.WriteLine(start);
                start--;
            }

            
        }
    }
}
