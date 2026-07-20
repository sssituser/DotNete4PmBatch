using System;

namespace UserDefinedMethods
{
    // num = 12             rev = 21
    // numsq = 144          revsq = 441  rev = 144

    //AM : public static
    //RT : bool
    //MN : IsAdam
    //PM : int
    internal class Class4
    {
        public static bool IsAdam(int num)
        {
          return  Square(num) ==  Reverse(Square(Reverse(num)));
        }

        private static int Reverse(int num)
        {

            int rev = 0;
            while (num > 0)
            { 
                rev = rev * 10 + num % 10;
                num /= 10;
            }
            return rev;
        }

        private static int Square(int num)
        {
            return num * num;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(IsAdam(12));
        }
    }
}
