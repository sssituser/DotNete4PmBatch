using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedMethods
{

    //153  1cube+5cube+3cube => 153
    // 1634 1pow4+6pow4+3pow4+4pow4=> 1634
    // 12 1sq+2sq=> 5 not Armstrong
    //1.Count digits (Power)
    //2.Separate digit %10
    //3.Find the Power values and
    //4.Sum
    //5.compare sum with given number

    // MN : IsArmstrong
   //  RT : bool
  //   PM : int
 //    AM : public static
    internal class Class3
    {
        public static bool IsArmstrong(int num) // 153
        {
            int pow = DigitCount(num);
            int copy = num;
            int sum = 0;
            while (num != 0) { 
                int digit = num % 10; 
                sum += Power(digit, pow);
                num /= 10;
            }
            return copy == sum;
        }

        private static int Power(int digit, int pow) // 5 ,3
        {
            int res = 1;
            for (int i = 0; i < pow; i++)
            {
                res *= digit; 
            }
            return res;
        }

        private static int DigitCount(int num)
        {
            int count = 0;
            while (num > 0)
            {
                count++;
                num /= 10;
            }
            return count;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(IsArmstrong(1));
            Console.WriteLine(IsArmstrong(123));
            Console.WriteLine(IsArmstrong(153));
            Console.WriteLine(IsArmstrong(1534));
            Console.WriteLine(IsArmstrong(1634));
        }
    }
}
