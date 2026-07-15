using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Class29
    {
        static void Main(string[] args)
        {
            int num = 5;
            for(int i= num; i >= 1; i--) //
            {
               for(int space = 1; space <= num - i; space++)
                {
                    Console.Write(" ");  
                }
               for(int star = 1; star <= i; star++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
