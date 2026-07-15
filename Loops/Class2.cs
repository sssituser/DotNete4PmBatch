using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Class2
    { //20
        // 2,4,6,8,10,12,14,16,18,20
        static void Main(string[] args)
        {
            int start = 2;
            int end = 20;
            while (start <= end)
            {
                Console.WriteLine(start);
                start += 2;
            }
        }
    }
}
