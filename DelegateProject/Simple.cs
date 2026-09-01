using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateProject
{
    internal class Simple<T,P>
    {
        public void Show(T a,T b)
        {
            Console.WriteLine($"a = {a}\tb = {b}");
        }
        public void Display(T a,P b)
        {
            Console.WriteLine($"a = {a}\tb = {b}");
        }
}    }

