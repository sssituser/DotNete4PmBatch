using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorApp
{
    class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        public int StudentMarks { get; set; }

        public void GetStudent()
        {
            Console.WriteLine($"Student Id : {StudentId}\tStudent Name : {StudentName}\tStudent Marks:{StudentMarks}");
        }
    }
    internal class Class2
    {
        static void Main(string[] args)
        {
            Student s1 = new Student() {StudentId=111,StudentName="abc",StudentMarks=9000 };
            s1.GetStudent();
            
        }
    }
}
