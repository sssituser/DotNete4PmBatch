using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            string s = "welcome";
            Console.WriteLine(s.ElementAt(3));// Parameter number gives character
            Console.WriteLine(s.ElementAt(5));
            Console.WriteLine(s.Contains("me"));
            Console.WriteLine(s.Contains("you"));
        }
    }
}
