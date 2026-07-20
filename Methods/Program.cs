using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "welcomes";
            Console.WriteLine(s.Length); // 8
            Console.WriteLine(s);//welcomes
            string res = s.ToUpper();
            Console.WriteLine(res);
            Console.WriteLine(s);// WELCOME
            Console.WriteLine(s);//welcomes

            
        }
    }
}
