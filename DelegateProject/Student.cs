using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateProject
{
    internal class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int StudentMarks { get; set; }

        public Student(int StudentId, string StudentName, int StudentMarks)
        {
            this.StudentId= StudentId;
            this.StudentName= StudentName;
            this.StudentMarks= StudentMarks;
        }
        public override string ToString()
        {
            return $"Student Id : {StudentId}\tStudent Name : {StudentName}\tStudent Marks : {StudentMarks} ";
        }
    }
}
