using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Class14
    {
        

        static void Main(string[] args)
        {
            Console.Write("Ener base Number : ");
            int bnum = int.Parse(Console.ReadLine()); // bnum = 2
            Console.Write("Enter Power Number : ");
            int power = int.Parse(Console.ReadLine()); // power = 3
            int res = 1, start = 1;
            while (start <= power) // 1<=3-T 2<=3 3<=3-T 4<=2
            {
                res = res * bnum; // res = 1*2 res = 2*2 res = 4*2 res = 8
                start++;// start = 2,3,4
            }
            Console.WriteLine($"{bnum} To The Power {power} is :{res}");

        }
    }
}
