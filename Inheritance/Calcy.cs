using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Calcy
    {
        int a, b;
        public Calcy(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public void Sum()
        {
            Console.WriteLine($"Sum is :{a + b}");
        }
        public void Sub()
        {
            Console.WriteLine($"Sub is :{a - b}");
        }
        public void Mul()
        {
            Console.WriteLine($"Mul is :{a * b}");
        }
        public void Div()
        {
            Console.WriteLine($"Quo is :{a / b}");

        }
    }
}