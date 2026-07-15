using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNete4PmBatch
{
    internal class Class12
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 2;
            Console.WriteLine(num1+num2);// 7
            Console.WriteLine(num1-num2);// 3
            Console.WriteLine(num1*num2);// 10
            Console.WriteLine(num1/num2);// 2
            Console.WriteLine(num1%num2);//` 1

            Console.WriteLine($"{num1+num2}     {num1-num2}     {num1*num2}");
           
            Console.WriteLine($"\nSum : {num1+num2}     Sub : {num1-num2}     Mul : {num1*num2}");
           
            Console.WriteLine($"\n{num1} + {num2} : {num1+num2}    {num1} - {num2}   : {num1-num2}    {num1} * {num2}  : {num1*num2}");
        
            
        
        
        }
    }
}
