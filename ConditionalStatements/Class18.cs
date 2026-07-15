using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    internal class Class18
    {
        ///  num = 1               res = 1pow1 = 1
        ///  num = 2               res = 2pow1 = 2
        ///  num = 11              res = 1sq+1sq=> 2
        ///  num = 153             res = 1cube+5cube+3cube => 153
        ///  num = 1634            res = 1pow4+6pow4+3pow4+4pow4=>1634
        /// steps
        /// Take the number
        /// Count the digits
        /// separate the digit
        ///  Find the power of the digits
        ///  sum of the powers of the digits
        ///  compare sum with given number
        ///  if both are equal amrstrong number or else not an Armstrong number


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
