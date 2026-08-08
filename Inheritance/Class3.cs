using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class A
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
    interface IB
    {
        void Sum();
        void Sub();
      

    }
    interface IC
    {
        void Mul();
        void Div();
    }
    class D : A, IB, IC
    {
        public void Rem()
        {
            Console.WriteLine($"Rem : {a%b}");
        }
        public void Div()
        {
            Console.WriteLine($" Quo is {a / b}");
        }

        public void Mul()
        {
            Console.WriteLine($" Mul is {a * b}");
            
        }

        public void Sub()
        {
            Console.WriteLine($" Sub is {a - b}");
            
        }

        public void Sum()
        {
            Console.WriteLine($" Sum is {a + b}");
        }
    }
    internal class Class3
    {
        static void Main(string[] args)
        {
            D p = new D();
            p.Read();
            p.Show();
            p.Sum();
            p.Mul();
            p.Div();
        }
    }
}
