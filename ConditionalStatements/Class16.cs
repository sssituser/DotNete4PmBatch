using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    internal class Class16
    {
        static void Main(string[] args)
        {
        Menu:
            Console.Write("Enter num1 : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter num2 : ");
            int num2 = int.Parse(Console.ReadLine());
      
            Console.Write("Add  Sub   Mul   Div   Mode Enter Your choice : ");
            string choice = Console.ReadLine();
           choice = choice.ToLower();
            switch (choice)
            {
                case "add":
                    Console.WriteLine($"Sum is : {num1+num2}");
                    goto Menu;//break;
                case "sub":
                    Console.WriteLine($"Sub is : {num1-num2}");
                    goto Menu;//break;
                case "mul":
                    Console.WriteLine($"Mul is : {num1*num2}");
                    goto Menu;//break;
                case "div":
                    Console.WriteLine($"Quo : {num1/num2}");
                    goto Menu;//break;
                case "mode":
                    Console.WriteLine($"Rem : {num1 % num2}");
                    goto Menu;//break;
                default:
                    Console.WriteLine("Invalid choice");
                    goto Menu;//break;

            }
        }
    }
}
