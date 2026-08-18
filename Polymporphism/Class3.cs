using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Polymporphism
{
    class Sample
    {
        int a, b;
        public void ReadValues(int a,int b)
        {
            this.a = a;
            this.b = b;
        }
        public void ShowValues()
        {
            Console.WriteLine($"a = {a}\tb = {b}");
        }
        public static Sample operator+(Sample l,Sample m)
        {
            Sample r = new Sample();
            r.a = l.a + m.a;
            r.b = l.b + m.b;
            return r;
        }
    }
    internal class Class3
    {
        static void Main(string[] args)
        {
            Sample s = new Sample();
            Console.WriteLine("===================================First Object=====================");
            s.ReadValues(4,5);
            s.ShowValues();
            Console.WriteLine("===================================Second Object=====================");
            Sample p = new Sample();
            p.ReadValues(2, 3);
            p.ShowValues();
            Console.WriteLine("===================================Third Object=====================");
            Sample r = new Sample();
            r = s + p;
            r.ShowValues();
        }
    }
}
