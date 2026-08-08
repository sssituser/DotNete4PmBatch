using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymporphism
{
    class Mover
    {
        public static void Display(int x)
        {
            Console.WriteLine(x);
        }
        public static void Display(double x)
        {
            Console.WriteLine(x);
        }
        public static void Display(string x)
        {
            Console.WriteLine(x);
        }
        public void Show(int x)
        {
            Console.WriteLine(x);
        }
        public void Show(string x)
        {
            Console.WriteLine(x);
        }
        public void Show(double x)
        {
            Console.WriteLine(x);
        }
    }
    internal class Class1
    {
        static void Main(string[] args)
        {
            Mover.Display(5);
            Mover.Display(9.8);
            Mover.Display("abc");
            Mover m = new Mover();
            m.Show(5);
            m.Show("abc");
            m.Show(5.6);
        }
    }
}
