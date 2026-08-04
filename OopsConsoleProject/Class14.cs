using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConsoleProject
{
    internal class Class14
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===============Employee-1 Object=================");
            Employeee emp1  = new Employeee();
            emp1.SetEmployee(111, "vijay", 50000);
            emp1.GetEmployee();
            Console.WriteLine("===============Employee-2 Object=================");
            Employeee emp2 = new Employeee();
            emp2.SetEmployee(112,"Poornima",5000);
            emp2.GetEmployee();
            emp1.GetEmployee();
            emp2.GetEmployee();
        }
    }
}
