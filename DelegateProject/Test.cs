using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateProject
{
    class Test
    {
        public static void Sum(int a, int b)
        {
            Console.WriteLine($"{a} + {b} = > {a + b}");
        }
        public static void Sub(int a, int b)
        {
            Console.WriteLine($"{a} - {b} = > {a - b}");
        }
        public void Mul(int a, int b)
        {
            Console.WriteLine($"{a} * {b} = > {a * b}");
        }
        public void Div(int a, int b)
        {
            Console.WriteLine($"{a} * {b} = > {a / b}");
        }
    }
}
