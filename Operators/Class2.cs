using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            int s1 = 30;
            int s2 = 40;
            int s3 = 50;
            Console.WriteLine(!(s1<35 ||s2<35||s3<35));
        }
    }
}
