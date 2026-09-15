using System;
using System.Collections.Generic;
namespace CollectionFramework
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee(111, "lmn", 50000));
            empList.Add(new Employee(113, "pqr", 55000));
            empList.Add(new Employee(109, "abc", 58000));
            empList.Add(new Employee(110, "def", 60000));
            empList.Add(new Employee(112, "xyz", 65000));

            Console.WriteLine("=====================Employees Information==================");
            foreach (var item in empList)
            {
                Console.WriteLine(item);
            }
            empList.Sort(new EmployeeIdComparer());
            
            Console.WriteLine("=====================Employees Information After Sorting==================");
            foreach (var item in empList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
