using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConsoleProject
{
    internal class  Class3
    {
        static void Main(string[] args)
        {

            Employee emp1 = new Employee();
            emp1.EmpId = 111;
            emp1.EmpName = "Test";
            emp1.EmpSal = 50000; // Write Only Property

            Console.WriteLine(emp1.EmpId);
            Console.WriteLine(emp1.EmpName);
            Console.WriteLine(emp1.EmpSal);  // Read Only Property
        }
    }
}
