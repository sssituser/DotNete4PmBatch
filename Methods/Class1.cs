using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            string res = "abc";
            Console.WriteLine(res); // abc
            string k = res.Replace('o', 'z');
            Console.WriteLine(res); // zbc
            Console.WriteLine(k);
        }
    }
}
