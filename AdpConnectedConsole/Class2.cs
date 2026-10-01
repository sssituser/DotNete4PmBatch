using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdpConnectedConsole
{
    internal class Class2
    {
        static async Task Main (string[] args)
        {
            Console.Write("Enter Employee Id : ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter Name : ");
            string name = Console.ReadLine();
            Console.Write("Enter Salary : ");
            int sal = int.Parse(Console.ReadLine());
            Employee emp = new Employee(id,name,sal);
            BusinessLogicc bl = new BusinessLogicc();
            if (await bl.AddEmployee(emp))
            {
                Console.WriteLine("Employee Added");
            }
            else
            {
                Console.WriteLine("Failed Add Employee");
            }
            
        }
    }
}
