using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorApp
{
    internal class Employee
    {
        private static string companyName;
        private int empId;
        private string empName;
        private int empSal;
        static Employee()
        {
            Console.WriteLine("Hi iam static constructor");
            companyName = "SSSIT";
        }
        public Employee()  // Defualt Constructor
        {
            Console.WriteLine("Hi Iam Default Constructor");
        }
        public Employee(int empId, string empName,int empSal) // construtor  with parameter
        {
            Console.WriteLine("Hi Iam Constructor with parameters");
            this.empId = empId;
            this.empName = empName;
            this.empSal = empSal;
        }

        public  Employee(Employee emp)
        {
            Console.WriteLine("Hi Iam Copy Constructor");
            this.empId= emp.empId;
            this.empName = emp.empName;
            this.empSal = emp.empSal;
        }
        public void GetEmployee()
        {
            Console.WriteLine($"Employee ID :{empId}\tEmployeeName : {empName}\tEmployeeSalary : {empSal}\nCompany Name : {companyName}");
        }
        ~Employee()
        {
            Console.WriteLine("Destructor Invoked...");
            Console.ReadLine();
          
        }
    }
}
