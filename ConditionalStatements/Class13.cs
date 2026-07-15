using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    internal class Class13
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Subject - 1 Marks : ");
            int sub1 = int.Parse(Console.ReadLine());

            Console.Write("Enter Subject - 2 Marks : ");
            int sub2 = int.Parse(Console.ReadLine());

            Console.Write("Enter Subject - 3 Marks : ");
            int sub3 = int.Parse(Console.ReadLine());
            
            int avg = (sub1 + sub2 + sub3) / 3;

            if (sub1<35 || sub2<35 || sub3 < 35)
            {
                Console.WriteLine("You are Failed");
            }
            else if (avg >= 60)
            {
                Console.WriteLine("Passed In A Grade");
            }else if (avg >= 50)
            {
                Console.WriteLine("Passed  In B Grade");
            }
            else
            {
                Console.WriteLine("Passed In C Grade");
            }
        }
    }
}
