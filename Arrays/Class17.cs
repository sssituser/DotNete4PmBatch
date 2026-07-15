using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Class17
    {
        static void Main(string[] args)
        {
            int[,] a = { { 11, 22, 33 }, { 44, 55, 66 }, { 77, 88, 99 } };
            Console.WriteLine("==================Array Element are===============");
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write($"{a[row,col]}\t");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("====================Diagonal Elements================");
            for (int row = 0; row < 3; row++)
            {
                for(int col = 0;col < 3; col++)
                {
                    if(row==col || row + col == 2)
                    {
                        Console.Write($"{a[row, col]}\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("====================Other Than Diagonal Elements================");
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (row == col || row + col == 2)
                    {
                        Console.Write("\t");
                       
                    }
                    else
                    {
                        Console.Write($"{a[row, col]}\t");

                    }
                }
                Console.WriteLine("\n");
            }
        }
    }

}
