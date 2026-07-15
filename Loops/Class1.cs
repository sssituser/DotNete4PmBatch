using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    // num = 20
    // 1,3,5,7,9,11,13,15,17,19
    internal class Class1
    {
        static void Main(string[] args)
        {
            int start = 1;
            int end = 20;




            do
            {
                Console.WriteLine(start);
                start += 2;// start = start+2
            } while (start <= end);




        }
    }
}
