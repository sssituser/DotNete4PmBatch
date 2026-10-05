using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEFExmple
{
    partial class Employee
    {
        public void Hi ()
        {
            Console.WriteLine("Hi Iam Hi method from class Employee");
        }
        public void Bye ()
        {
            Console.WriteLine("Hi Iam Bye Method from class Employee");
        }
    }
    internal class Class1
    {
        static void Main (string[] args)
        {
            Employee emp = new Employee();
            emp.Hi();
            emp.Bye();
        }
    }
}
