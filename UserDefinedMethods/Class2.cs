using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedMethods
{

    //num = 123 rev = 321  
    internal class Class2
    {
        // AM : public static
        // RT : boolean
        // MN : IsPalindrome
        // PM : int

        // AM : public static
       //  RT : int
      //   MN : Reverse
      //   PM : int

        public static int Reverse(int num)
        {
            int rev = 0;
            while (num != 0)
            {
                rev = rev * 10 + num % 10;
                num /= 10;
            }
            return rev;
        }

        public static bool IsPalindrome(int num) // num = 123
        {
    
            return Reverse(num) == num;
            
        }
        static void Main(string[] args)
        {
            Console.Write("Enter num: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(IsPalindrome(num));
         
           
        }
    }
}
