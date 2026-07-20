using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedMethods
{
    internal class Class6
    { // AM : publi static
        //MN :IsPerfect
        //RT : bool
        //PM : int

       public static bool IsPerfect(int num)
        {
            int sum = 0;
            for(int i = 1; i < num; i++)
            {
                if (IsFactor(num,i)) //10 2
                {
                    sum += i;
                }
            }
            return sum==num;
        }

        private static bool IsFactor(int num, int i)
        {
            return num % i == 0;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(IsPerfect(6));
            Console.WriteLine(IsPerfect(28));
            Console.WriteLine(IsPerfect(12));
        }
    }
}
