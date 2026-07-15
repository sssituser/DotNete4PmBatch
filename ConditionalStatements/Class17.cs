using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    /*Find the minimum digit from the given number
     * num = 123 min = 1
     * num = 654 min = 4
     */
    internal class Class17
    {
        static void Main(string[] args)
        {
            Console.Write("Enter  number : ");
            int num = int.Parse(Console.ReadLine()); // num = 120

            int min = num%10;// min = 9
            while (num > 0) //999>0-T
            {
                int  digit = num % 10; // digit = 9
                if(digit<min)
                {
                    min = digit; 
                }
                num = num / 10; 

            }

            Console.WriteLine($"Minimum digit is {min}");
        }
    }
}
