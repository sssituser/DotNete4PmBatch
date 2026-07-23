using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedMethods
{
    /* MN: PalinsList
     * PT: 2 integers start,end
     * RT: string
     * AM : public static
     * 
     * Depends :
     *      IsPalindrome
     *          Reverse
     */
    internal class Class9
    {
        public static string PalinsList(int start,int end)
        {
            string res = string.Empty;
            for(int i = start; i <= end; i++)
            {
                if (IsPalindrome(i))
                {
                    res = res + i + ",";
                }

            }
            return $"Palindrome List : {res.Substring(0,res.Length-1)+"."}";

        }

        private static bool IsPalindrome(long num)
        {
            return num == Reverse(num);
        }

        private static long Reverse(long num)
        {
            long rev = 0;
            while (num > 0)
            {
                rev = rev * 10 + num % 10;
                num /= 10;
            }
            return rev;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(PalinsList(1,1000));
        }
    }
}
