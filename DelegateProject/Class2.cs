using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateProject
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            Simple<int, string> p = new Simple<int, string>();
            p.Show(10, 20);
            Simple<int, string> q = new Simple<int, string>();
            q.Display(1111, "KIran");
            Simple<Employee, Student> r = new Simple<Employee, Student>();
            r.Display(new Employee(111,"abc",5000),new Student(131,"def",600));
        }
    }
}
