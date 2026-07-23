using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedMethods
{
    /*
     * 1. Readable
     * 2. Changeble
     * 3. Testable--- Methods
     */
    /// <summary>
    /// Create an application which gives lucky number for the given date of birth
    /// Rules:
    /// Date of Birth : 10-Oct-2020  LuckyNumber : 10+10+2020=> 2040=>2+0+4+0=>6
    /// </summary>
    /// date = 10 Month = Oct (ConverMonthTextToNum)10  year = 10 
    ///  sum = date+month+year => 2040=> 2+0+4+0=>6
    internal class Class12
    {
        //MN : GetLuckyNumber
        //PM : string dob
        //RT : int
        //AM : public static

        public static long GetLuckyNumber(string dob)// 10 - Oct - 2020
        {
            string[] res = dob.Split('-');
            int date = int.Parse(res[0]);
            int month =ConvertMontTextToNum(res[1]);
            int year = int.Parse(res[2]);
            int sum = date + month + year; // 2040
            while (sum > 9)
            {
                sum = DigitSum(sum);
            }
            return sum;
        }

        private static int DigitSum(int num) // num = 123
        {
            int sum = 0;
            while (num > 0)
            {
                int digit = num % 10;
                sum = sum + digit;
                num = num / 10;// num = 12
            }
            return sum;
        }

        private static int ConvertMontTextToNum(string month) // January
        {
            month = month.ToLower();
            string[] months = {"jan","feb","mar","apr","may","jun","jul","aug","sep","oct","nov","dec" };
            for(int i = 0; i < months.Length; i++)
            {
                if (month.Contains(months[i]))
                {
                    return i + 1;
                }
            }
            return 0;
        }

        static void Main(string[] args)
        {
            string dob = "14-Nov-2002";
            Console.WriteLine(GetLuckyNumber(dob));
        }
    }
}
