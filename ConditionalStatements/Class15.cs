using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    internal class Class15
    {
        static void Main(string[] args)
        {
            Console.Write("Enter num1 : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter num2 : ");
            int num2 = int.Parse(Console.ReadLine());
            Menu:
            Console.Write("1.Add\n2.Sub\n3.Mul\n4.Div\n5.Rem\nEnter Ur choice : ");
            int choice = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Sum is :{num1+num2}");
                    goto Menu;//break;
                case 2:
                    Console.WriteLine($"Sub is :{num1 - num2}");
                    goto Menu;//break;
                case 3:
                    Console.WriteLine($"Mul is :{num1 * num2}");
                    goto Menu;//break;
                case 4:
                    Console.WriteLine($"Quo is :{num1 / num2}");
                    goto Menu;//break;
                case 5:
                    Console.WriteLine($"Mul is :{num1 % num2}");
                    goto Menu;//break;
                default:
                    Console.WriteLine("Invalid Choice, Enter Proper Choice");
                    break;
            }

        }
    }
}
