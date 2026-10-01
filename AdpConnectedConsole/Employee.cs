using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdpConnectedConsole
{
    internal class Employee
    {
        public int EmployeeId { get; set; }
        public string  EmployeeName { get; set; }
        public int   EmployeeSalary { get; set; }
        public Employee (int EmployeeId,string EmployeeName,int EmployeeSalry)
        {
            this.EmployeeId = EmployeeId;
            this.EmployeeName = EmployeeName;
            this.EmployeeSalary = EmployeeSalry;
        }
    }
}
