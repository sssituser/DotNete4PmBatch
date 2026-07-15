using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Age : ");
            int age =int.Parse(Console.ReadLine());//Reding values
            if (age >17 ) // 18>17 - T
            {
                Console.WriteLine("You are Eligible for vote");
            }
            if (age < 18) // 18<18 - F
            {
                Console.WriteLine("You are not Eligible for vote");
            }

            
        }
    }
}
