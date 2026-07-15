using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    internal class Class11
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Age : ");
            int age = int.Parse(Console.ReadLine());
            if (age > 17)
            {
                if (age < 21)
                {
                    Console.WriteLine("You are Major , You are Eligible Vote but not for Marriage");
                }
                else
                {
                    Console.WriteLine("You are Major , You are Eligible Vote and Marriage");
                }
            }
            else
            {
                Console.WriteLine("You are minor");
            }
        }
    }
}
