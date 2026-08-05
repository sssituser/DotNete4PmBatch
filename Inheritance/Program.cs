using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class SciCalcy :Calcy
    {
        public SciCalcy(int x,int y) :base(x,y)
        {

        }
        public void Sine(int val)
        {
            Console.WriteLine(Math.Sin(val));
        }
        public void Cos(int val)
        {
            Console.WriteLine(Math.Cos(val));
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           SciCalcy sc = new SciCalcy(5,2);
            sc.Sine(90);
            sc.Cos(0);
            sc.Sum();
            sc.Sub();
            sc.Mul();
            sc.Div();
        }
    }
}
