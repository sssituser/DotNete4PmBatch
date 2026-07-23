using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedMethods
{
    /// <summary>
    /// MN : IsPerfect
    /// RT : boolean
    /// PM : integr
    /// AM : public static 
    /// </summary>
    internal class Class7
    {
        public static bool IsPerfect(int num) // num = 6 1,2,3,4,5,
        {
            int sum = 0;
            for(int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                }
            }
            return num == sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(IsPerfect(6));
            Console.WriteLine(IsPerfect(5));
            Console.WriteLine(IsPerfect(8));
            Console.WriteLine(IsPerfect(28));
        }
    }
}
