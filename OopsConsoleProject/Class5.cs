using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConsoleProject
{
    class Employ
    {
        private int empId; // Privte field

        public int EmployeeId  // Property
        {
            get { return empId; } // Read
            set { empId = value; } // Write 
        }
        public void ShowEmployee()
        {
            Console.WriteLine($"Private Field Employee : {empId}");
        }

    }
    internal class Class5
    {
        static void Main(string[] args)
        {
            Employ emp = new Employ();
            emp.EmployeeId = 111;
            emp.ShowEmployee();
        }
    }
}
