using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Class25
    {
        static void Main(string[] args)
        {
            int num = 5;
            for (int row = 1; row <= num; row++) // row = 1 row = 2 row = 3 row = 4
            {

                for (int j = 1; j <= row; j++)// j = 1
                {
                    Console.Write($"{row}\t"); //  1  2  2 3 3 3
                }
                Console.WriteLine();

            }
        }
    }
}
