using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{ // Write a program to add two numbers

    // MN : Add/Sum/
    // PM : 2 integers
    // RT : integer
    // AM : public static
    internal class Class8
    {
        public static int Sum(int num1,int num2) // defined 
        {
            return num1 + num2;
        }
        public static int Sub(int num1,int num2)
        {
            return num1 - num2;
        }
        public static int Mul(int num1, int num2)
        {
            return num1 * num2;
        }
        public static int Div(int num1,int num2)
        {
            return num1 / num2;
        }
        static void Main(string[] args)
        {
           int res = Sum(4, 3);// Recomended
            Console.WriteLine($"Sum is : {res}");
            Console.WriteLine($"Sum is : {Sum(2,3)}");
            Console.WriteLine($"Sub is : {Sub(2,3)}");
            Console.WriteLine($"Mul is : {Mul(2,3)}");
            Console.WriteLine($"Quo is : {Div(5,2)}");
        }
    }
}
