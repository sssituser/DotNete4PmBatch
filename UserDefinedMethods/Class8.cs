using System;
namespace UserDefinedMethods
{
    /// <summary>
    /// num = 145    sum = 1!+4!+5! => 1+24+120 => 145
    /// MN : IsStrong
    /// PT : Int
    /// RT : bool
    /// AM : public static
    /// </summary>
    internal class Class8
    {
        int num = 145;
        public static bool IsStrong(int num) // num = 145
        {
            long sum = 0;
            long copy = num; // copy = 145
            while (num != 0) // 145!=0- 14!-0-T 1!=0-T 0!=0-F
            {
                int digit = num % 10; // digit = 5 digit = 4 digit = 1
                sum +=  Factorial(digit); // sum = 144 sum = 145
                num /= 10; // num = 145/10 num = 14/10 num = 1/10 num = 0
            }
            return sum == copy;

        }

        private static long Factorial(int num) // num = 5
        {
            int res = 1;
            for(int i = 1; i <= num; i++)
            {
                res *= i;
            }
            return res;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(IsStrong(145));
            Console.WriteLine(IsStrong(120));
        }
    }
}
