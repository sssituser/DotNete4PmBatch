using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DelegateProject
{

    public delegate void DelegateClass(int a, int b);

    internal class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test();
            DelegateClass d1 = new DelegateClass(Test.Sum);
            DelegateClass d2 = new DelegateClass(Test.Sub);
            DelegateClass d3 = new DelegateClass(t.Mul);
            DelegateClass d4 = new DelegateClass(t.Div);

            DelegateClass d5 = d1 + d2 + d3 + d4;
            d5(5, 2);
            d5(7, 3);
         
            
        }
    }
}
