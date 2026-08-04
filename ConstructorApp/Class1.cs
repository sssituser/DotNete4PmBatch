using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorApp
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================================Employee-1======================");
            Employee employee1 = new Employee(111,"abc",50000);
            employee1.GetEmployee();
            Console.WriteLine("=================================Employee-2======================");
            Employee employee2 = new Employee();
            employee2.GetEmployee();
            Console.WriteLine("=================================Employee-3======================");
            Employee employee3 = new Employee(employee1);
            employee3.GetEmployee();
            Employee employee4 = new Employee();
        }
    }
}
