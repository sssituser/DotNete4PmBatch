using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            string res = "test";
            Console.WriteLine(res.IndexOf("e")); // takes character , gives number
            Console.WriteLine(res.IndexOf('e'));
            Console.WriteLine(res.IndexOf('s'));
            Console.WriteLine(res.IndexOf('t'));
            Console.WriteLine(res.LastIndexOf('t'));
        }
    }
}
