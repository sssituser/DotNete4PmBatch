using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Class5
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Subject-1 Marks : ");
            int s1 = int.Parse(Console.ReadLine());   // s1 = 30
            Console.Write("Enter Subject-2 Marks : ");
            int s2 = int.Parse(Console.ReadLine());   // s2 = 50
            Console.Write("Enter Subject-3 Marks : ");
            int s3 = int.Parse(Console.ReadLine());  // s3 = 60
            Console.WriteLine(s1<35 || s2<35 || s3<35 ? "Fail":"Pass");
        }
    }
}
