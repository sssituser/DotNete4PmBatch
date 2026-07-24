using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedMethods
{


    internal class Class14
    {

        public static int GetMaxNum(int[] array)
        {
           return ArrayToNum(SortArrayDesc(GetMaxDigitArray(array)));
        }
        public static int[] GetMaxDigitArray(int[] array)
        {
            int[] res = new int[array.Length];
            for(int i = 0; i < res.Length; i++)
            {
                res[i] = GetMaxDigit(array[i]);
            }
            return res;

        }

        private static int GetMaxDigit(int num)
        {
            int max = num % 10;
            while (num != 0)
            {
                int digit = num % 10;
                if (digit > max)
                {
                    max = digit;
                }
                num = num / 10;
            }
            return max;
        }

        public static int[] SortArrayDesc(int[] array)
        {

            Array.Sort(array);
            Array.Reverse(array);
            return array;
        }
        public static int ArrayToNum(int[] array)//{9,5,1}
        {
            int res = 0;
            for(int i = 0; i < array.Length; i++)
            {
                res =res*10+ array[i];
            }
            return res;
        }
        static void Main(string[] args)
        {
            int[] array = { 123, 456, 788, 987, 445, 667 };
            Console.WriteLine(GetMaxNum(array));
        }
    }
}
