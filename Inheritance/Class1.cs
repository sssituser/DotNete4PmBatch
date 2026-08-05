using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Dept
    {
        int deptId;
        string deptName;
        string deptHead;
        public Dept(int deptId,string deptName,string deptHead)
        {
            this.deptId = deptId;
            this.deptName = deptName;
            this.deptHead = deptHead;
        }
        public void ShowDept()
        {
            Console.WriteLine($"DeptId : {deptId}\tDeptName : {deptName}\tDept Head :{deptHead}");
        }
    }

    class Employee :Dept
    {
        int empId;
        string empName;
        int empSal;
        public Employee(int empId,string empName,int empSal,int deptId,string deptName,string deptHead):base(deptId,deptName,deptHead)
        {
            this.empId = empId;
            this.empName = empName;
            this.empSal = empSal;
        }
        public void ShowEmployee()
        {
            Console.WriteLine($"Employee Id : {empId}\tEmployee Name : {empName}\tEmployee Salary : {empSal}");
            
        }
    }



    internal class Class1
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(111,"abc",5000,100,"Hr","Kiran");
            emp.ShowEmployee();
            emp.ShowDept();
        }
    }
}
