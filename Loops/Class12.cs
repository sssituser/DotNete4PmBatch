using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Class12
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number  : ");
            int num = int.Parse(Console.ReadLine());
            int rev = 0;
            while (num != 0) 
            {
                int digit = num % 10; 
                rev = rev * 10 + digit;
                num /= 10;
            }
            Console.WriteLine($"Reverse Number is :{rev}");
        }
    }
}
