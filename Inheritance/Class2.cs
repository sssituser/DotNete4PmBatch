using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Test
    {
        protected int a, b;
        public void Read()
        {
            Console.Write("Enter a value : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter b value : ");
            b = int.Parse(Console.ReadLine());
        }
        public void Show()
        {
            Console.WriteLine($"a = {a}\tb = {b}");
        }

    }
    class Sample : Test
    {
        public void Sum()
        {
            Console.WriteLine($"Sum is :{a+b}");
        }
        public void Sub()
        {
            Console.WriteLine($"Sub is :{a - b}");
        }

    }
    class Simple : Sample
    {
        public void Mul()
        {
            Console.WriteLine($"Mul is : {a * b}");
        }
        public void Div()
        {
            Console.WriteLine($"Div is : {a / b}");
        }
    }
    internal class Class2
    {
        static void Main(string[] args)
        {
            Simple s = new Simple();
            s.Read();
            s.Show();
            s.Sum();
            s.Sub();
            s.Mul();
            s.Div();
        }
    }
}
