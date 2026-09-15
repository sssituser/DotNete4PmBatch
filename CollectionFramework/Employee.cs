using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFramework
{
    internal class Employee : IComparable<Employee>
    {


        public int EmployeeId { get; set; }
         public string EmployeeName { get; set; }

        public int EmployeeSalary { get; set; }
        public Employee(int employeeId, string employeeName, int employeeSalary)
        {
            EmployeeId = employeeId;
            EmployeeName = employeeName;
            EmployeeSalary = employeeSalary;
        }
        public override string ToString()
        {
            return $"Employee ID : {EmployeeId}\tEmployee Name : {EmployeeName}\tEmployee Salary : {EmployeeSalary}";
        }
        public int CompareTo(Employee other)    //sorting based employeename
        {
            return EmployeeName.CompareTo(other.EmployeeName);
        }


    }
}
