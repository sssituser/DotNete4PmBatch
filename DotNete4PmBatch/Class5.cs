using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNete4PmBatch
{
    internal class Class5
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"size of byte    : {sizeof(byte)} Byte");
            Console.WriteLine($"size of sbyte   : {sizeof(sbyte)} Byte");
            Console.WriteLine($"size of short   : {sizeof(short)} Bytes");
            Console.WriteLine($"size of int     : {sizeof(int)} Bytes");
            Console.WriteLine($"size of long    : {sizeof(long)} Bytes");
            Console.WriteLine($"size of float   : {sizeof(float)} Bytes");
            Console.WriteLine($"size of double  : {sizeof(double)} Bytes");
            Console.WriteLine($"size of decimal : {sizeof(decimal)} Bytes");
            Console.WriteLine($"size of char    : {sizeof(char)} Bytes");
            Console.WriteLine($"size of bool    : {sizeof(bool)} Byte");
        }
    }
}
