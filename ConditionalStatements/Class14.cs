using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    internal class Class14
    {
        static void Main(string[] args)
        {
            Console.Write("Enter num1 : ");
            int num=int.Parse(Console.ReadLine());
            if (num == 0)
            {
                Console.WriteLine("ZERO");
            }else if (num == 1)
            {
                Console.WriteLine("ONE");
            }else if (num == 2)
            {
                Console.WriteLine("TWO");
            }else if (num == 3)
            {
                Console.WriteLine("THREE");
            }
            else
            {
                Console.WriteLine("Entered Nubmer is Other than 0,1,2,3");
            }
        }
    }
}
