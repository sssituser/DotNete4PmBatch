using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEFExmple
{
    partial class Employee
    {
        public void Show ()
        {
            Console.WriteLine("Hi this Show method from Employee class");
        }
        public void Display ()
        {
            Console.WriteLine("Hi this is Display method from Employee class");
        }
    }
    internal class Class2
    {
        static void Main (string[] args)
        {
            Employee emp = new Employee();
            emp.Hi();
            emp.Bye();
            emp.Show();
            emp.Display();

        }
    }
}