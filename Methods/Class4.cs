using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Class4
    {
        static void Main(string[] args)
        {
            string dob = "abc-def-pqr";
            string[] res = dob.Split('-');
            Console.WriteLine(res[0]);
            Console.WriteLine(res[1]);
            Console.WriteLine(res[2]);
        }
    }
}
