using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymporphism
{
    internal class Class5
    {
        static void Main(string[] args)
        {
            Employee emp=new Employee();
            emp.SetEmployee(111,"vijay",6000);
            Console.WriteLine(emp);

            
        }
    }
}
