using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConsoleProject
{
    internal class Employeee
    {
        int empId ;
        string empName;
        int empSal;
        public void SetEmployee(int empId, string empName,int empSal) // local variables
        {
            this.empId = empId;
            this.empName= empName;
            this.empSal = empSal;
           
        }
       public void GetEmployee()
        {
            Console.WriteLine($"Employee ID : {empId}\tEmployee Name : {empName}\tEmployee Salary : {empSal}");
        }
    }
}
