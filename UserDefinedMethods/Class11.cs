using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedMethods
{
    /*
     * MN : PerfectList
     * PM : start,end long
     * RT : string
     * AM : public static
     */
    internal class Class11
    {
        public static string PerfectList(long start,long end)
        {
            string res = string.Empty;
            for(long i= start;i<=end;i++)
            {
                if (IsPerfect(i))
                {
                    res = res+ i + ",";
                }
            }
            return $"Perfect List : {res.Substring(0, res.Length - 1) + "."}";
        }

        private static bool IsPerfect(long num)
        {

            long sum = 0;
           for(long i=1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                }
            }
            return sum == num;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(PerfectList(1,10000));
        }
    }
}
