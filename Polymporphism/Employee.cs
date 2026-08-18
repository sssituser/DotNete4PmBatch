using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymporphism
{
    internal class Employee 
    {
        int empId;
        string empName;
        int empSal;
        public void SetEmployee(int empId,string empName,int empSal)
        {
            this.empId = empId;
            this.empName = empName;
            this.empSal = empSal;
        }
        public override string ToString()
        {
            return $"Employee ID : {empId}\tEmployee Name : {empName}\tEmployee Salary : {empSal}";
        }
    }
}
