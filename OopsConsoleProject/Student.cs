using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConsoleProject
{
    internal class Student
    {
		private static string collegeName = "SSSIT";
		private static string  address="KPHB";

		private int studentId;
		private string studentName;
		private int marks;

		public int Marks
		{
			get { return marks; }
			set { marks = value; }
		}

		public string StudentName
		{
			get { return studentName; }
			set { studentName = value; }
		}

		public int StudentId
		{
			get { return studentId; }
			set { studentId = value; }
		}

		public static string Address
		{
			get { return address; }

		}

		public static string CollegeName
		{
			get { return collegeName; }
			
		}

	}
}
