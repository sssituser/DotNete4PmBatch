using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedMethods
{////
    /// <summary>
    /// MN : ArmstrongList
    /// PM : 2 Integers start,end
    /// RT : string
    /// AM : public static
    /// Depends :
    ///     IsArmstong
    ///         DigitCount
    ///         Power
    /// </summary>
    internal class Class10
    {
        public static string ArmstongList(long start, long end)
        {
            string res = string.Empty;

            for (long i = start; i <= end; i++)
            {
                if (IsArmstong(i))
                {
                    res = res + i+",";
                }

            }
            return $"Armstrong List : {res.Substring(0,res.Length-1)+"."}";
        }

        private static bool IsArmstong(long num)
        {
            long power = DigitCount(num);
            long copy = num;
            long sum = 0;
            while (num != 0)
            {
                long digit = num % 10;
                sum = sum + Power(digit, power);
                num /= 10;
            }
            return sum == copy;

        }

        private static long Power(long digit, long power)
        {
            long res = 1;
            for(int i = 1; i <= power; i++)
            {
                res *= digit;
            }
            return res;

        }

        private static long DigitCount(long num)
        {
            string res = num + "";
            return res.Length;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ArmstongList(1,10000));
        }
    }
}
