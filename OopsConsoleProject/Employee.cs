using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConsoleProject
{
    internal class Employee
    {
		private int empId;

		private string empName;

		private int empSal;

		public int EmpSal
		{
			get { return empSal; }
			set { empSal = value; }
		}

		public string EmpName
		{
			get { return empName; }
			set { empName = value; }
		}

		public int EmpId
		{
			get 
			{ return empId; }
			set { empId = value; }
		}

	}
}
