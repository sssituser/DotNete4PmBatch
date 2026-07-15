using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators  
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter num1 : ");
            int num1 = int.Parse(Console.ReadLine()); //5
            Console.Write("Enter num2 : ");
            int num2 = int.Parse(Console.ReadLine()); //2
            Console.WriteLine("============Arithmetic Operations================");
            Console.WriteLine($"{num1+num2}     {num1-num2}     {num1*num2}      {num1/num2}     {num1%num2}");
            Console.WriteLine("================Comparision Oprators======================");
            Console.WriteLine($"{num1>num2}     {num1>=num2}     {num1<num2}   {num1<=num2}      {num1==num2}      {num1!=num2}");
        
        }
    }
}
