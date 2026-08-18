using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymporphism
{
    class Test
    {
        public void Display()
        {
            Console.WriteLine("Hi this is display method from Test class");
        }
        public virtual void Show()
        {
            Console.WriteLine("Hi this is show method from Test class");
        }
    }
    class Samplee :Test
    {
        public void Hi()
        {
            Console.WriteLine("Hi this is hi method from Samplee class");
        }
        public void Bye()
        {
            Console.WriteLine("Hi this is Bye method from class Samplee");
        }
        public override void Show()
        {
            Console.WriteLine("Hi this is show method from samplee classs");
        }
    }
    internal class Class4
    {
        static void Main(string[] args)
        {
            Test s;
            s = new Test();
            s.Display();
            s.Show();
            s = new Samplee();
            s.Show();
        }
    }
}
