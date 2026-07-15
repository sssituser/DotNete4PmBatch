using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNete4PmBatch
{
    internal class Class4
    {
        static void Main(string[] args)
        {
            Console.WriteLine(sizeof(byte)); //1
            Console.WriteLine(sizeof(sbyte)); //1
            Console.WriteLine(sizeof(short)); //2
            Console.WriteLine(sizeof(ushort));//2
            Console.WriteLine(sizeof(int)); //4
            Console.WriteLine(sizeof(uint));//4
            Console.WriteLine(sizeof(long));//8
            Console.WriteLine(sizeof(ulong));//8
            Console.WriteLine(sizeof(float));//4
            Console.WriteLine(sizeof(double));//8
            Console.WriteLine(sizeof(decimal));//16
            Console.WriteLine(sizeof(char));//2
            Console.WriteLine(sizeof(bool));//1
        }
    }
}
