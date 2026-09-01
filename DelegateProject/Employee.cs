using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateProject
{
    internal class Employee
    {
        public int EmployeeId { get; set; }
        public string    EmployeeName { get; set; }
        public int EmployeeSalary { get; set; }

        public Employee(int EmployeeId, string EmployeeName, int EmployeeSalary)
        {
            this.EmployeeId= EmployeeId;
            this.EmployeeName= EmployeeName;
            this.EmployeeSalary= EmployeeSalary;
        }
        public override string ToString()
        {
            return $"EmployeeId :{EmployeeId}\tEmployeeName : {EmployeeName}\tEmployeeSalary : {EmployeeSalary}";
        }

    }
}
