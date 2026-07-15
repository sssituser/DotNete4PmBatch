using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Class16
    {
        static void Main(string[] args)
        {
            int[,] a = { { 12, 34, 56 }, { 77, 88, 99 } };
            for (int row = 0; row < 2; row++) // row = 0 0<2-T row=1 1<2-T row = 2 2<2-F
            {
                for(int col = 0; col < 3; col++) // col = 0 0<3-T col=1 1<3-T col=2 2<3-T col=3 3<3-F
                {
                    Console.Write($"{a[row,col]}\t");//12   34  56
                }                                    //77   88  99
                Console.WriteLine();
            }
        }
    }
}
