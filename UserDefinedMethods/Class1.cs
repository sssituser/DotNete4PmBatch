using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedMethods
{
    internal class Class1
    {
        // Reverse of Given number ;

        // Parameter : integer(num)
        // RT : int
        // MN : Reverse
        // AM : public static

        public static int Reverse(int num) // 123
        {
            int rev = 0;
            while (num > 0)
            { 
                rev = rev * 10 + num%10;
                num /= 10; 
            }
            return rev;
        }

        // number = 345   MaxDigit = 5
        // Parameter : 1-Integer
        // RT : Integer
        // MN : MaxDigit
        // AM : public static

        public static int MaxDigit(int num)
        {
            int max = num % 10;
            while (num > 0)
            {
                int digit = num % 10;
                if (digit > max)
                {
                    max = digit;
                }
                num /= 10;
            }
            return max;
        }
        public static int MinDigit(int num)
        {
            int min = num % 10;
            while (num > 0)
            {
                int digit = num % 10;
                if (digit<min)
                {
                    min = digit;
                }
                num /= 10;
            }
            return min;
        }

        /*Find the NameScore of a Given Name : abc
         input : abc    res = 1+2+3=>6


          PM : string 
          RT : int
          MN : NameScore
          AM : public static
         
         */
        public static int NameScore(string name) // ABC
        {
            name = name.ToLower();
            string alphs = "abcdefghijklmnopqrstuvwxyz";
            int res = 0;
            foreach(char ch in name) 
            {
              res +=  alphs.IndexOf(ch)+1; 
            }
            return res;
        }



        //Write a program to encryp the given strig
        // input : abc  ans :zyx

        //1.PM : string
        //2.RT : string
        //3.MN : Encrpyt
        //4.AM : public static

        public static string Encrpyt(string name) // name = "abc"
        {
            name = name.ToLower();
            string res = string.Empty;
            string alpas = "abcdefghijklmnopqrstuvwxyz";
           
            foreach(char ch in name) // "abc" ch = 'a'
            {
                res = res + alpas.ElementAt(25-alpas.IndexOf(ch));
            }
            return res;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Reverse(123));
            Console.WriteLine(MaxDigit(123));
            Console.WriteLine(MinDigit(123));
            Console.WriteLine(NameScore("KarunA"));
            Console.WriteLine(NameScore("VIjay"));
            Console.WriteLine(NameScore("THIRMALRAO"));
            Console.WriteLine(NameScore("POORNIMA"));
            Console.WriteLine(Encrpyt("arun"));
            Console.WriteLine(Encrpyt("POORNIMA"));
            Console.WriteLine(Encrpyt("vijay"));
        }
    }
}
