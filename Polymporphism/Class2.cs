using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymporphism
{
    class Areas
    {
        public static void Area(int s)
        {
            Console.WriteLine($"Area of a Square is :{s*s}");
        }
        public static void Area(int l,int b)
        {
            Console.WriteLine($"Area of a Rectangle is :{l * b}");
        }
        public static void Area(double r)
        {
            Console.WriteLine($"Area of a Circle is :{3.14*r*r}");
        }
    }
    internal class Class2
    {
        static void Main(string[] args)
        {
            Areas.Area(4, 5);
            Areas.Area(5.6);
            Areas.Area(5);

            
        }
    }
}
