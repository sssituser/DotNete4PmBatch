using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Console.Write("Enter num1 : ");
            int num1 = int.Parse(Console.ReadLine()); // 10
            Console.Write("Enter num2 : ");
            int num2 = int.Parse(Console.ReadLine()); //20

            Console.WriteLine($"num1 = {num1}\tnum2 = {num2}"); // 10    20

            num1 += num2;  // num1 = num1 + num2;

            Console.WriteLine($"num1 = {num1}\tnum2 = {num2}"); // 30    20

            num1 -= num2; // num1 = num1 - num2

            Console.WriteLine($"num1 = {num1}\tnum2 = {num2}"); // 10    20

            num1 *= num2; // num1 = num1*num2
            Console.WriteLine($"num1 = {num1}\tnum2 = {num2}");

            num1 /= num2;// num1 = num1/num2

            Console.WriteLine($"num1 = {num1}\tnum2 = {num2}");

            num1 %= num2; // num1 = num1 % num2
            Console.WriteLine($"num1 = {num1}\tnum2 = {num2}");

        }
    }
}
